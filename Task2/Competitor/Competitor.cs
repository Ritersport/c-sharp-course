using Model;
using Strategy;

namespace Competitor;

public class Competitor : ICompetitor
{
    private readonly IStrategy _strategy;
    private Deck _deck;
    

    public Competitor(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetDeck(Deck deck)
    {
        _deck = deck;
    }

    public Card GetCard()
    {
        var num = _strategy.GetCardNumber(_deck);

        return _deck.GetCardByNumber(num);
    }

    public void ClearDeck()
    {
        _deck.Clear();
    }
}