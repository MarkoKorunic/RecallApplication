using System;
using System.Collections.Generic;
using System.Text;

namespace RecallApplication.BusinessLayer
{
    public class Card
    {
        public Card()
        {
            Deck = new Deck() { Name = "Default" };
            DateCreated = DateTime.Now;
        }

        public string Question { get; set; }
        public string Answer { get; set; }
        public Deck Deck { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
