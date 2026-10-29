using System.ComponentModel.DataAnnotations;
using Poker;

namespace TestPoker;

public class Tests
{
    private static IEnumerable<TestCaseData> Cases =>
    [
        new TestCaseData(
            new[]
            {
                new[] { 6, 7, 8, 9, 9 },
                new[] { 6, 7, 8, 9, 9 },
                new[] { 6, 7, 8, 9, 9 }
            },
            27)
    ];

    [TestCaseSource(nameof(Cases))]
    public void TestPokerCal(int[][]card, int expected)
    {
        var pokerCal = new PokerCal();

        var result = pokerCal.combinaisonCal(card);
        
        Assert.Pass();
    }
}