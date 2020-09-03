using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecallApplication.BusinessLayer;

namespace RecallApplication.DataAccessLayer
{

    public class CardData
    {
        public CardData()
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
