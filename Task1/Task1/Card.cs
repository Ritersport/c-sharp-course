namespace Task1;

public class Card
{ 
    private readonly bool _isRed;

    public Card(bool isRed)
    {
        this._isRed = isRed;
    }

    public bool GetIsRed()
    {
        return _isRed;
    }
}