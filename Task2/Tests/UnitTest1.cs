using Model;
using Strategy;

namespace Tests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Deck_Shuffler_Success()
    {
        int redCardsNum = 18;
        int blackCardsNum = 18;
        Deck deck = new Deck(redCardsNum + blackCardsNum, redCardsNum);
        int redCounter = 0;
        int blackCounter = 0;
        deck.Shuffle();
        foreach (Card card in deck.GetCardList())
        {
            if (card.GetColor() == CardColor.Black)
            {
                blackCounter++;
            }
            else
            {
                redCounter++;
            }
        }
        Assert.True((redCounter == redCardsNum) && (blackCounter == blackCardsNum));
    }

    [Test]
    [TestCase(18)]
    [TestCase(9)]
    [TestCase(1)]
    public void Strategy_First_Last_Success(int redCardsNum)
    {
        int cardsNum = 18;
        int expectedNumber = 0;
        Deck deck = new Deck(cardsNum, redCardsNum);
        deck.Shuffle();
        if (deck.GetCardByNumber(cardsNum - 1).GetColor() == CardColor.Black)
        {
            expectedNumber = 0;
        }
        else
        {
            expectedNumber = cardsNum - 1;
        }
        IStrategy strategy = new StrategyFirstOrLast();
        int number = strategy.GetCardNumber(deck);
        Assert.True(expectedNumber == number);
    }
    
    [Test]
    [TestCase(18)]
    [TestCase(9)]
    [TestCase(1)]
    public void Strategy_Always_First_Success(int redCardsNum)
    {
        int cardsNum = 18;
        int expectedNumber = 0;
        Deck deck = new Deck(cardsNum, redCardsNum);
        deck.Shuffle();
        IStrategy strategy = new StrategyAlwaysFirst();
        int number = strategy.GetCardNumber(deck);
        Assert.True(expectedNumber == number);
    }
    
    
    [Test]
    public void Shuffle_Check()
    {
        Deck deck = new Deck(36, 18);
        deck.Shuffle();
        
    }
}