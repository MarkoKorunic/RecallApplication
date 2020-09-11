using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecallApplication.BusinessLogic;

namespace RecallApplication.Console
{
    class ReadCardScreen
    {
        public void Show()
        {
            var CursorPosition = 0;
            while (true)
            {
                
                System.Console.Clear();
                System.Console.WriteLine("Kartice:");
                BusinessLogic.Card card = new BusinessLogic.Card();
                BusinessLogic.Deck clDeck = new BusinessLogic.Deck();
                clDeck.Load();
                for (int i = 0; i < clDeck.CardList.Count; i++)
                {
                    card = clDeck.CardList[i];
                    string textLine = card.Deck.Name + "|" + card.Question + "|" + card.Answer + "|" + card.DateCreated.ToShortDateString();
                    if (i == CursorPosition)
                    {
                        CursorMarker(textLine);

                    }
                    else
                    {
                        System.Console.WriteLine(textLine);
                    }

                }
                System.Console.WriteLine("Izbornik:");
                System.Console.WriteLine("Vrati se na HomeScreen- F1");
                System.Console.WriteLine("Tipke UP/DOWN za odabir. ENTER za pregled." );
                var UserKey = System.Console.ReadKey();
                if(UserKey.Key == ConsoleKey.F1)
                {
                    return;
                }

                if(UserKey.Key == ConsoleKey.UpArrow)
                {
                    CursorPosition--;
                }

                if(UserKey.Key == ConsoleKey.DownArrow)
                {
                    CursorPosition++;
                }


                
            }
        }

        public void CursorMarker(string textLine)
        {
            System.Console.BackgroundColor = ConsoleColor.White;
            System.Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine(textLine);
            System.Console.BackgroundColor = ConsoleColor.Black;
            System.Console.ForegroundColor = ConsoleColor.White;
        }
         
        


    }
}
