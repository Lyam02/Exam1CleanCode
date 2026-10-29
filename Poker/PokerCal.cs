namespace Poker;

public class PokerCal
{
    public int combinaisonCal(int[][] card)
    {
        int somme = card.Select(main => main.Max()).Sum();
        
        return somme;
    }
}