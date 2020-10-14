using System;
using System.Drawing;
using System.Text;
using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using TicTacToeMQTT.Model;
using TicTacToeMQTT.View;

namespace TicTacToeMQTT.Controller
{
    public class GameController
    {
        private IManagedMqttClient _mqttClient = new MqttFactory().CreateManagedMqttClient();
        private string _baseTopic = "ticTacToe/";
        private GameView _gameView;
        private Game _game;
        private Random _random = new Random();

        public GameController(GameView gameView)
        {
            this._gameView = gameView;
        }

        public GameView GameView => _gameView;

        public async void connectButton_Click(object sender, EventArgs e)
        {
            _gameView.disableConnectionStuff();
            
            var options = new ManagedMqttClientOptionsBuilder()
                .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
                .WithClientOptions(new MqttClientOptionsBuilder()
                    .WithClientId(_gameView.getPlayerName())
                    .WithTcpServer("broker.hivemq.com", 1883)
                    .Build())
                .Build();
            
            await _mqttClient.StartAsync(options);
            
            await _mqttClient.SubscribeAsync(new TopicFilterBuilder().WithTopic(_baseTopic + "+/" + _gameView.getGameId()).Build());
            
            _mqttClient.UseDisconnectedHandler(d =>
            {
                Console.WriteLine("Disconnected!");
            });
            
            _mqttClient.UseApplicationMessageReceivedHandler(async f =>
            {
                if (getOpponentFromTopic(f.ApplicationMessage.Topic) == _gameView.getPlayerName())
                {
                    return;
                }

                string payLoad = $"{Encoding.UTF8.GetString(f.ApplicationMessage.Payload)}";

                if (payLoad == "Connected!")
                {
                    _game = new Game(getOpponentFromTopic(f.ApplicationMessage.Topic), _gameView.getPlayerName(), _gameView.getGameId(), "X");
                    initializeSquareClicks();

                    String whoStarts;
                    if (_random.Next(0, 10) > 5)
                    {
                        whoStarts = "iStart";
                        
                        _gameView.enableSquares();
                    }
                    else
                    {
                        whoStarts = "youStart";
                    }
                    
                    await _mqttClient.PublishAsync(new MqttApplicationMessageBuilder()
                        .WithTopic(_baseTopic + _game.Player + "/" + _game.GameId)
                        .WithPayload(whoStarts)
                        .Build());

                    _gameView.setStatus("Playing against: " + getOpponentFromTopic(f.ApplicationMessage.Topic));
                }
                else if (payLoad == "iStart")
                {
                    _game = new Game(getOpponentFromTopic(f.ApplicationMessage.Topic), _gameView.getPlayerName(), _gameView.getGameId(), "O");
                    initializeSquareClicks();

                    _gameView.setStatus("Playing against: " + getOpponentFromTopic(f.ApplicationMessage.Topic));
                }
                else if (payLoad == "youStart")
                {
                    _game = new Game(getOpponentFromTopic(f.ApplicationMessage.Topic), _gameView.getPlayerName(), _gameView.getGameId(), "O");
                    initializeSquareClicks();
                    
                    _gameView.enableSquares();
                    
                    _gameView.setStatus("Playing against: " + getOpponentFromTopic(f.ApplicationMessage.Topic));
                }
                else if (payLoad.StartsWith("clicked:"))
                {

                    GameSquareView gameSquareView =
                        _gameView.findSquare(Int32.Parse(payLoad.Substring(payLoad.Length - 1, 1)));

                    if (_game.Side == "X")
                    {
                        gameSquareView.Text = "O";
                    }
                    else
                    {
                        gameSquareView.Text = "X";
                    }
                    
                    if (checkIfWin() != "notYet")
                    {
                        _gameView.setStatus(getOpponentFromTopic(f.ApplicationMessage.Topic) + " has beat you!");
                        _gameView.disableSquares();
                    }
                    else
                    {
                        _gameView.enableSquares();
                    }
                }
            });
            
            
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(_baseTopic + _gameView.getPlayerName() + "/" + _gameView.getGameId())
                .WithPayload("Connected!")
                .Build();

            await _mqttClient.PublishAsync(message);
            
            _gameView.setStatus("Waiting for other player...");

            _gameView.disableSquares();
        }

        public void initializeSquareClicks()
        {
            foreach (var gameSquareViewRow in _gameView.GridView)
            {
                foreach (var gameSquareView in gameSquareViewRow)
                {
                    gameSquareView.Click += gameSquare_Click;
                }
            }
        }

        public async void gameSquare_Click(object sender, EventArgs e)
        {
            GameSquareView clickedButton = sender as GameSquareView;

            await _mqttClient.PublishAsync(new MqttApplicationMessageBuilder()
                .WithTopic(_baseTopic + _game.Player + "/" + _game.GameId)
                .WithPayload("clicked:" + clickedButton.Id)
                .Build());

            clickedButton.Text = _game.Side;
            
            _gameView.disableSquares();

            if (checkIfWin() != "notYet")
            {
                _gameView.setStatus("You won!");
            }
        }

        private String getOpponentFromTopic(String topic)
        {
            return topic.Split('/')[1];
        }

        private string checkIfWin()
        {
            foreach (var gameSquareViewRow in _gameView.GridView)
            {
                if(gameSquareViewRow[0].Text == gameSquareViewRow[1].Text && gameSquareViewRow[1].Text == gameSquareViewRow[2].Text && gameSquareViewRow[0].Text != "")
                {
                    gameSquareViewRow[0].BackColor = Color.LawnGreen;
                    gameSquareViewRow[1].BackColor = Color.LawnGreen;
                    gameSquareViewRow[2].BackColor = Color.LawnGreen;
                    return gameSquareViewRow[0].Text;
                }
            }

            for (var i = 0; i < 3; i++)
            {
                if (_gameView.GridView[0][i].Text == _gameView.GridView[1][i].Text &&
                    _gameView.GridView[1][i].Text == _gameView.GridView[2][i].Text && _gameView.GridView[0][i].Text != "")
                {
                    _gameView.GridView[0][i].BackColor = Color.LawnGreen;
                    _gameView.GridView[1][i].BackColor = Color.LawnGreen;
                    _gameView.GridView[2][i].BackColor = Color.LawnGreen;
                    return _gameView.GridView[0][i].Text;
                }
            }

            if (_gameView.GridView[0][0].Text == _gameView.GridView[1][1].Text && _gameView.GridView[1][1].Text == _gameView.GridView[2][2].Text && _gameView.GridView[0][0].Text != "")
            {
                _gameView.GridView[0][0].BackColor = Color.LawnGreen;
                _gameView.GridView[1][1].BackColor = Color.LawnGreen;
                _gameView.GridView[2][2].BackColor = Color.LawnGreen;
                return _gameView.GridView[0][0].Text;
            }

            if (_gameView.GridView[2][0].Text == _gameView.GridView[1][1].Text && _gameView.GridView[1][1].Text == _gameView.GridView[0][2].Text && _gameView.GridView[2][0].Text != "")
            {
                _gameView.GridView[2][0].BackColor = Color.LawnGreen;
                _gameView.GridView[1][1].BackColor = Color.LawnGreen;
                _gameView.GridView[0][2].BackColor = Color.LawnGreen;
                return _gameView.GridView[2][0].Text;
            }

            return "notYet";
        }
    }
}