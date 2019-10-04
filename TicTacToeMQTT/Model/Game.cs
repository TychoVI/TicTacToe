using System;
using System.Text;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;

namespace TicTacToeMQTT.Model
{
    public class Game
    {
        private string _opponent;
        private string _player;
        private string _gameId;
        private string _side;

        public Game(string opponent, string player, string gameId, string side)
        {
            this._side = side;
            this._opponent = opponent;
            this._player = player;
            this._gameId = gameId;
        }

        public string Opponent
        {
            get => _opponent;
            set => _opponent = value;
        }

        public string Player => _player;

        public string GameId => _gameId;

        public string Side => _side;

        public void Connect(string name, string gameId)
        {
            
        }
    }
}