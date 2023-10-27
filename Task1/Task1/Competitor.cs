namespace Task1;

public class Competitor
{
    private List<Card> _cards = new List<Card>();

    public void SetNewCardDeck(List<Card> deck)
    {
        _cards?.Clear();
        _cards = deck;
    }

    public Card GetCard(int num)
    {
        return _cards[num - 1];
    }

    public void DiscardDeck()
    {
        _cards.Clear();
    }
}