using System;
using System.Collections.Generic;
using RecallApplication.BusinessLogic;
using System.IO;
using System.Linq;

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

        public void Load()
        {
            CardList = new List<Card>();
            DataAccessLayer.Deck deck = new DataAccessLayer.Deck();
            Deck blDeck = new Deck();
            deck.Load();
            

            foreach(var card in deck.CardList)
            {
                

                Card blCard = new Card();
                blCard.Deck = blDeck;
                blCard.Question = card.Question;
                blCard.Answer = card.Answer;
                blCard.DateCreated = card.DateCreated;
                CardList.Add(blCard);
                
            }

            CardList= CardList.OrderByDescending(carddate => carddate.DateCreated).ToList();
            

        }


    }

    
    






}
