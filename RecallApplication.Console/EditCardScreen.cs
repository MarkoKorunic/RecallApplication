using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecallApplication.BusinessLogic;
using RecallApplication.BussinesLogic;

namespace RecallApplication.Console
{
    class EditCardScreen
    {
        public void Show()
        {
            System.Console.Clear();
            System.Console.WriteLine("Unesite pitanje.");
            Card card = new Card();
            card.Question = System.Console.ReadLine();
            System.Console.WriteLine("Unesite odgovor.");
            card.Answer = System.Console.ReadLine();
            // pozvati businies layer da snimi CArd u Deck
            Deck deck = new Deck();
            deck.Save(card);
            System.Console.WriteLine("Uspješno snimljena kartica.");
        }


    }
}
