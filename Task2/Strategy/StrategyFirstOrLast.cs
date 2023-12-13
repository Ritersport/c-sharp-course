using Model;

namespace Strategy;

public class StrategyFirstOrLast : IStrategy
{
    public int GetCardNumber(Deck deck)
    {
        if (deck.GetCardByNumber(deck.GetNumOfCards() - 1).GetColor() == CardColor.Black)
        {
            return 0;
        }

        return deck.GetNumOfCards() - 1;
    }
}