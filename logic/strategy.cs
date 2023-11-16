using client_dotnet.models;

public class Strategy
{
    
    
    public static Bet Decide(Table? table) {
        // fold on null data
        System.Diagnostics.Debug.WriteLine("#########################");
        Console.WriteLine("#########################");
        if (table is null)
        {
            Console.WriteLine("Table Null");
            return new Bet(0);
        }
        return new Bet(table.minimumBet);
        
        var ourPlayer = table.players[table.activePlayer];

        if (HasSimilarRanks(ourPlayer) == false && HasSimilarSuits(ourPlayer) == false)
        {
            Console.WriteLine("bet null - bad Cards");
            return new Bet(0);
            
        }
        
        Console.WriteLine("bet minimum");
        return new Bet(table.minimumBet);
    }


    public static Bet Fold => new Bet(0);
    
    
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

