using System;
using System.Windows.Forms;
using TicTacToeMQTT.Controller;

namespace TicTacToeMQTT.View
{
    public partial class GameView : Form
    {
        private GameController _gameController;
        private GameSquareView[][] gridView;
        
        public GameView()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            gridView = new[]
            {
                new[] {gameSquare0, gameSquare1, gameSquare2}, new[] {gameSquare3, gameSquare4, gameSquare5},
                new[] {gameSquare6, gameSquare7, gameSquare8}
            };

        }

        public GameController GameController
        {
            get => _gameController;
            set => _gameController = value;
        }

        public GameSquareView[][] GridView => gridView;

        public string getPlayerName()
        {
            return nameBox.Text;
        }

        public string getGameId()
        {
            return gameBox.Text;
        }

        public void setStatus(String status)
        {
            statusLabel.Text = status;
        }

        public void enableSquares()
        {
            foreach (var gameSquareViewRow in gridView)
            {
                foreach (var gameSquareView in gameSquareViewRow)
                {
                    if (gameSquareView.Text == "")
                    {
                        gameSquareView.Enabled = true;
                    }
                }
            }
        }

        public void disableSquares()
        {
            foreach (var gameSquareViewRow in gridView)
            {
                foreach (var gameSquareView in gameSquareViewRow)
                {
                    gameSquareView.Enabled = false;
                }
            }
        }

        public GameSquareView findSquare(int id)
        {
            foreach (var gameSquareViewRow in gridView)
            {
                foreach (var gameSquareView in gameSquareViewRow)
                {
                    if (gameSquareView.Id == id)
                    {
                        return gameSquareView;
                    }
                }
            }
            return null;
        }

        public void disableConnectionStuff()
        {
            nameBox.Enabled = false;
            gameBox.Enabled = false;
            connectButton.Enabled = false;
        }
    }
}