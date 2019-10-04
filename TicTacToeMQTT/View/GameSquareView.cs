using System.Windows.Forms;

namespace TicTacToeMQTT.View
{
    public class GameSquareView : Button
    {
        private int _id;

        public GameSquareView(int id)
        {
            this._id = id;
        }
        
        public void Claim(string player)
        {
            this.Enabled = false;
            this.Text = player;
        }

        public int Id => _id;
    }
}