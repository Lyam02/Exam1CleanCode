namespace Poker;

public class PokerCal
{
    public int combinaisonCal(int[][] card)
    {
        
        int somme = card.Sum(main =>
        {
            bool aUnBrelan = main
                .GroupBy(carte => carte)
                .Any(groupe => groupe.Count() == 3);

            return aUnBrelan ? 30 : main.Max();
        });
        
        return somme;
    }
}