using client_dotnet.models;

public class Strategy
{
    public static Bet Decide(Table? table) {
        // fold on null data
        if (table is null) return new Bet(0);
        
        var ourPlayer = table.players[table.activePlayer];

        if (HasSimilarRanks(ourPlayer) == false && HasSimilarSuits(ourPlayer) == false)
        {
            return new Bet(0);
        }
        return new Bet(table.minimumBet);
    }
    
    
    
    static bool HasSimilarRanks(Player player)
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

    static bool HasSimilarSuits(Player player)
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

