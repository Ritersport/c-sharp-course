namespace Task1;

public class RomanGod
{
    private readonly List<Card> _deck = new List<Card>(DeckSize);
    private const int DeckSize = 36;
    private const int NumOfRedCards = 18;

    public void ShuffleCards()
    {
        int redCardsCounter = 0;
        var rnd = new Random();
        for (var i = 0; i < DeckSize; i++)
        {
            var tmp = rnd.Next(0, 2);
            if (tmp == 0 && NumOfRedCards > redCardsCounter)
            {
                    _deck.Add(new Card(true));
                    redCardsCounter++;
            }
            else
            {
                _deck.Add(new Card(false));
            }
        }
    }

    public List<Card> GetFirstHalfOfCards()
    {
        return _deck.GetRange(0, DeckSize / 2);
    }

    public List<Card> GetSecondHalfOfCards()
    {
        return _deck.GetRange(DeckSize / 2 - 1, DeckSize / 2);
    }

    public void DiscardDeck()
    {
        _deck.Clear();
    }
}

//стратегия каждому игроку
//колода отдельный класс
//енам с цветом
//вынеси всё в отдельную сборку
