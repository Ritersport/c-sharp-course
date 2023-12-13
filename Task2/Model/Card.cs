namespace Model;

public class Card
{
    private readonly CardColor _color;

    public Card(CardColor color)
    {
        _color = color;
    }

    public CardColor GetColor() => _color;
}