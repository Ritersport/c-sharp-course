
using Model;
using Strategy;

namespace Competitor;

public interface ICompetitor
{

   void SetDeck(Deck deck);

   Card GetCard();

   void ClearDeck();
}