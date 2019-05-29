using System;

namespace MyMonoGame.DesktopGL
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            using (var game = new Game1())
            {
                game.Run();
            }
        }
    }
}
