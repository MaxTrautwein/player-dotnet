using client_dotnet.models;

public class Strategy
{
    public static Bet Decide(Table? table) {
        // fold on null data
        if (table is null) return new Bet(0);
        
        var ourPlayer = table.players[table.activePlayer];

        

        Card[] allCards = AllCards(table.players[table.activePlayer].cards, table.communityCards);
        var card = numericCard.TransformCards(allCards);
        
        
        return new Bet(table.minimumBet);
    }

    public static Card[] AllCards(Card[] playerCards, Card[] commCards)
    {
        Card[] allCards;
         allCards = playerCards.Concat(commCards).ToArray();
         
         return allCards;
    }
    
    
    
    
}

