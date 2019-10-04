using System;
using System.Windows.Forms;
using MQTTnet.Extensions.ManagedClient;
using TicTacToeMQTT.View;

namespace TicTacToeMQTT.Controller
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GameView gameView = new GameView();
            GameController gameController = new GameController(gameView);
            gameView.connectButton.Click += gameController.connectButton_Click;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(gameController.GameView);
        }
    }
}