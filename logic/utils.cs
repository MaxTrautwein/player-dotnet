namespace client_dotnet.logic;

public static class CardCombinations
{
    public static HashSet<Tuple<Rank, Rank>> GetDesiredCombinations()
    {
        return new HashSet<Tuple<Rank, Rank>>
        {
            new Tuple<Rank, Rank>(Rank.A, Rank.K),
            new Tuple<Rank, Rank>(Rank.A, Rank.Q),
            new Tuple<Rank, Rank>(Rank.A, Rank.J),
            new Tuple<Rank, Rank>(Rank.A, Rank._10),
            new Tuple<Rank, Rank>(Rank.K, Rank.Q),
            new Tuple<Rank, Rank>(Rank.K, Rank.J),
            new Tuple<Rank, Rank>(Rank.K, Rank._10),
            new Tuple<Rank, Rank>(Rank.Q, Rank.J),
            new Tuple<Rank, Rank>(Rank.Q, Rank._10),
            new Tuple<Rank, Rank>(Rank.J, Rank._10),
            new Tuple<Rank, Rank>(Rank.J, Rank._9),
            new Tuple<Rank, Rank>(Rank._10, Rank._9),
        };
    }
}

public class GameUtils
{
    
    public static bool HasDesiredCombination(Player player)
    {
        var desiredCombinations = CardCombinations.GetDesiredCombinations();

        if (player?.cards == null || player.cards.Length < 2)
            return false;

        for (int i = 0; i < player.cards.Length; i++)
        {
            for (int j = i + 1; j < player.cards.Length; j++)
            {
                var pair1 = new Tuple<Rank, Rank>(player.cards[i].rank, player.cards[j].rank);
                var pair2 = new Tuple<Rank, Rank>(player.cards[j].rank, player.cards[i].rank);
            
                if (desiredCombinations.Contains(pair1) || desiredCombinations.Contains(pair2))
                {
                    return true;
                }
            }
        }

        return false;
    }


    
    public static bool HasSimilarRanks(Player player)
    {
        if (player?.cards == null || player.cards.Length < 2)
            return false;

        for (int i = 0; i < player.cards.Length; i++)
        {
            for (int j = i + 1; j < player.cards.Length; j++)
            {
                if (player.cards[i].rank == player.cards[j].rank)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool HasSimilarSuits(Player player)
    {
        if (player?.cards == null || player.cards.Length < 2)
            return false;

        for (int i = 0; i < player.cards.Length; i++)
        {
            for (int j = i + 1; j < player.cards.Length; j++)
            {
                if (player.cards[i].suit == player.cards[j].suit)
                {
                    return true;
                }
            }
        }

        return false;
    }
}