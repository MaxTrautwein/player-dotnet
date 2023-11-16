public class Strategy
{
    public static Bet decide(Table? table) {
        // fold on null data
        if (table is null) return new Bet(0);
        
        var ourPlayer = table.players[table.activePlayer];
        
        
        return new Bet(table.minimumBet);
    }
}

