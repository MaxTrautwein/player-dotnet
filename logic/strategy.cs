using System.Security.Cryptography.X509Certificates;
using client_dotnet.logic;
using client_dotnet.models;

public class Strategy
{
    public static Bet Decide(Table? table) {
        // fold on null data
        if (table is null) return new Bet(0);
        
        var ourPlayer = table.players[table.activePlayer];

        
        Card[] allCards = AllCards(table.players[table.activePlayer].cards, table.communityCards);
        var numerischeKarte = numericCard.TransformCards(allCards);

        if ( compares.HasPair(numerischeKarte) > 0 )
        {
            return new Bet(table.minimumRaise);
        }
        else
        {
            return new Bet(0);
        }

        
    }

    public static Card[] AllCards(Card[] playerCards, Card[] commCards)
    {
        Card[] allCards;
         allCards = playerCards.Concat(commCards).ToArray();
         
         return allCards;
    }
    
    
    
    
}

