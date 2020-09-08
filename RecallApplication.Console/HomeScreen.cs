using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecallApplication.Console
{
    public class HomeScreen
    {
        public void Show()
        {
            while (true)
            {
                System.Console.Clear();
                System.Console.WriteLine("IZBORNIK");
                System.Console.WriteLine("Dodaj karticu - F1");
                System.Console.WriteLine("Kraj - F8");
                var UserKeyAdd = System.Console.ReadKey();
                if (UserKeyAdd.Key == ConsoleKey.F8)
                {
                    System.Console.WriteLine("Jeste li sigurni? Stisnite 'Y' ako jeste. Ako ne, stisnite bilo koju tipku.");
                    var KeyCheck = System.Console.ReadKey();
                    if (KeyCheck.Key == ConsoleKey.Y)
                    {
                        return;
                    }

                    
                }

                if (UserKeyAdd.Key == ConsoleKey.F1)
                {
                    EditCardScreen editCardScreen = new EditCardScreen();
                    editCardScreen.Show();
                }

            }
               
        }



    }
}
