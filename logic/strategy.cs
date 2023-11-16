using client_dotnet.logic;
using client_dotnet.models;

public class Strategy
{
    public static Bet Decide(Table? table) {
        // fold on null data
        if (table is null) return new Bet(0);
        
        var ourPlayer = table.players[table.activePlayer];

        if (GameUtils.HasSimilarRanks(ourPlayer) == false && GameUtils.HasSimilarSuits(ourPlayer) == false)
        {
            return new Bet(0);
        }
        return new Bet(table.minimumBet);
    }
    
    
    

    
}

