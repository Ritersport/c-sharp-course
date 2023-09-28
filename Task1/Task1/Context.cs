using Strategy;

namespace Task1;

public class Context
{
    private IStrategy? _strategy;
    private readonly RomanGod _romanGod = new RomanGod();
    private readonly Competitor _elon = new Competitor();
    private readonly Competitor _mark = new Competitor();
    
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public bool PlayGame()
    {
        _romanGod.ShuffleCards();
        _elon.SetNewCardDeck(_romanGod.GetFirstHalfOfCards());
        _mark.SetNewCardDeck(_romanGod.GetSecondHalfOfCards());
        
        if (_strategy == null)
        {
            EndGame();
            throw new Exception("strategy is not set");
        }
        var elonNum = _strategy.GetCardNumber(1);
        var markNum = _strategy.GetCardNumber(2);

        var elonCard = _elon.GetCard(elonNum);
        var markCard = _mark.GetCard(markNum);
        
        EndGame();
        return elonCard.GetIsRed() == markCard.GetIsRed();
    }

    private void EndGame()
    {
        _romanGod.FreeTheDeck();
    }
}