using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RecallApplication.DataAccessLayer
{
    public class Deck
    {
        private const string path = @"C:\RecallApp\DefaultDeck.txt";


        public Deck()
        {
            DateCreated = DateTime.Now;
        }
        public string Name { get; set; }
        public DateTime DateCreated { get; }

        public List<CardData> CardList { get; set; }

        public void Save()
        {
            
          //petlja za cardlist foreach

            foreach(var cardData in CardList)
            {
                // za svaki Card data nparavit liniju za upis, sve properties odvojit sa | 
                string textLine = cardData.Deck.Name + "|" + cardData.Question + "|" + cardData.Answer + "|" + cardData.DateCreated.ToShortDateString();
                //pohranit linije u file
                File.AppendAllLines(path, new List<string>() { textLine });
            }



           



        }

        public void Load()
        {
            CardList = new List<CardData>();

            //učitati sve podatke iz DefaultDeck.txt
            string[] textLines = File.ReadAllLines(path);
            //petlja za provjeru svih članova
            foreach(var textLine in textLines)
            {
                string[] properties = textLine.Split('|');
                CardData card = new CardData();
                card.Deck = new Deck();

                card.Deck.Name = properties[0];
                card.Question = properties[1];
                card.Answer = properties[2];
                card.DateCreated = Convert.ToDateTime(properties[3]);

                CardList.Add(card);
                
            }
            

            //ubacit ih u svojstvo CardList

        }

    }
   


}

