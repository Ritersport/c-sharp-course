using Model;

namespace Shuffler;

public class DeckShuffler : IDeckShuffler
{
    public Tuple<Deck, Deck> Shuffle(Deck deck)
    {
        deck.Shuffle();
        
        Deck firstDeck = new Deck(deck.GetNumOfCards() / 2, deck.GetFirstHalfRedCards());
        Deck secondDeck = new Deck(deck.GetNumOfCards() / 2, deck.GetNumOfRedCards() - deck.GetFirstHalfRedCards());
        for (int i = 0; i < deck.GetNumOfCards() / 2; i++)
        {
            firstDeck.AddCard(deck.GetCardByNumber(i));
            secondDeck.AddCard(deck.GetCardByNumber(deck.GetNumOfCards() / 2 + i));
        }

        return new Tuple<Deck, Deck>(firstDeck, secondDeck);
    }
    
}