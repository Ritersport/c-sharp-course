using Competitor;
using Model;
using Shuffler;

namespace Experiment;

public class Sandbox
{
    private readonly ICompetitor _elon;
    private readonly ICompetitor _mark;
    private readonly IDeckShuffler _shuffler;
    public Sandbox(IEnumerable<ICompetitor> players, IDeckShuffler shuffler)
    {
        _elon = players.ToArray()[0];
        _mark = players.ToArray()[1];
        _shuffler = shuffler;
    }
    

    public bool PlayGame()
    {
        var decks = _shuffler.Shuffle(new Deck(36, 18));
        _elon.SetDeck(decks.Item1);
        _mark.SetDeck(decks.Item2);

        var elonCard = _elon.GetCard();
        var markCard = _mark.GetCard();
        
        EndGame();
        return elonCard.GetColor() == markCard.GetColor();
    }

    private void EndGame()
    {
        _elon.ClearDeck();
        _mark.ClearDeck();
    }
    
}