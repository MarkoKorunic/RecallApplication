using System;
using System.Collections.Generic;

namespace RecallApplication.BusinessLayer
{
    public class Deck
    {
        public Deck()
        {
            DateCreated = DateTime.Now;
        }
        public string Name { get; set; }
        public DateTime DateCreated { get; }

        public List<Card> CardList { get; set; }


    }

    
    






}
