using System;
using System.Windows.Forms;

using Speedrunning_Game_Forms;

namespace Speedrunning_Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		[STAThread]
        static void Main(string[] args)
        {
//			LoginForm login = new LoginForm(false);
//			DialogResult result = login.ShowDialog();
//			Game1.userName = login.username;
//			if (result == DialogResult.OK || result == DialogResult.Ignore)
//			{
				using (Game1 game = new Game1(false))
				{
					game.Run();
				}
//			}
        }
    }
}

