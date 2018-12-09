
using Lesson9.Game;
using Lesson9.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//kuriam zaidima!
namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GuiController guiController = new GuiController();
            //GameController gameController = new GameController();
            //gameController.StartGame();
            guiController.ShowMenu();

            Console.ReadKey();

        }
    }
}
