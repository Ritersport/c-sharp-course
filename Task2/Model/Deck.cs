using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace Model;

public class Deck
{
    private const int MaxDeckSize = 36;
    private List<Card> _deck = new List<Card>(MaxDeckSize);
    private int _numOfCards;
    private int _numOfRedCards;
    private int _firstHalfRedCards;

    public Deck(int numOfCards, int numOfRedCards)
    {
        _numOfCards = numOfCards;
        _numOfRedCards = numOfRedCards;
    }

    public int GetNumOfCards() => _numOfCards;
    public int GetNumOfRedCards() => _numOfRedCards;
    public int GetFirstHalfRedCards() => _firstHalfRedCards;
    
    public Deck Shuffle()
    {
        int redCardsCounter = 0;
        var rnd = new Random();
        _deck.Clear();
        for (int i = 0; i < _numOfCards; i++)
        {
            var tmp = rnd.Next(0, 2);
            if (tmp == 0 && _numOfRedCards > redCardsCounter)
            {
                _deck.Add(new Card(CardColor.Red));
                if (i < _numOfCards / 2)
                {
                    _firstHalfRedCards++;
                }
                redCardsCounter++;
            }
            else
            {
                _deck.Add(new Card(CardColor.Black));
            }
        }

        return this;
    }

    public Card GetCardByNumber(int number)
    {
        return _deck[number];
    }

    public void AddCard(Card card)
    {
        _deck.Add(card);
    }

    public void Clear()
    {
        _deck.Clear();
    }
}

