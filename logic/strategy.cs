using client_dotnet.logic;
using client_dotnet.models;

public class Strategy
{
    public static Bet Decide(Table? table) {
        // fold on null data
        if (table is null) return new Bet(0);
        
        var ourPlayer = table.players[table.activePlayer];

        // fold if no pair (suits or ranks)
        if (GameUtils.HasSimilarRanks(ourPlayer) == false && GameUtils.HasSimilarSuits(ourPlayer) == false)
        {
            return new Bet(0);
        }
        
        // only in round 1 (player have 2 cards, no cards on table)
        if (table.communityCards == null || table.communityCards.Length == 0)
        {
            if (GameUtils.HasSimilarSuits(ourPlayer) && GameUtils.HasDesiredCombination(ourPlayer))
            {
                // all in
                return new Bet(ourPlayer.stack);
            }
        }
        
        return new Bet(table.minimumBet);
    }
    
    
    

    
}

