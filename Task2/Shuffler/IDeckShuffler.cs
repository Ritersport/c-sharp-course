using Model;

namespace Shuffler;

public interface IDeckShuffler
{
    Tuple<Deck, Deck> Shuffle(Deck deck);

}

