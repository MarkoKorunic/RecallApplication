using System;
using System.Collections.Generic;
using RecallApplication.BussinesLogic;

namespace RecallApplication.BusinessLogic
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

        public void Save(Card card)
        {
            DataAccessLayer.Deck deck = new DataAccessLayer.Deck();
            DataAccessLayer.CardData cardData = new DataAccessLayer.CardData();
            cardData.Question = card.Question;
            cardData.Answer = card.Answer;
            cardData.Deck = deck;
            cardData.DateCreated = card.DateCreated;
            deck.CardList = new List<DataAccessLayer.CardData>();
            deck.CardList.Add(cardData);
            deck.Save();
        }
    }

    
    






}
