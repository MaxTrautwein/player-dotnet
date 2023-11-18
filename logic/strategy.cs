using System.Security.Cryptography.X509Certificates;
using client_dotnet.logic;
using client_dotnet.models;

public class Strategy
{
    public static Bet Decide(Table? table)
    {
        // fold on null data
        if (table is null) return new Bet(0);

        var ourPlayer = table.players[table.activePlayer];
        int activePlayer = table.activePlayer;
        Card[] myCards = table.players[activePlayer].cards;

        Card[] allCards = AllCards(table.players[activePlayer].cards, table.communityCards);
        var numericAllCards = NumericCard.TransformCards(allCards);

        // wenn keine community cards liegen aber:
        // ... wir nen assKing suited haben
        //      oder
        // ... wir nen AssKing offsuited haben
        //      oder
        // ... wir AceJack suited haben
        //      dann minRaise * 2
        if (table.communityCards?.Length == 0)
        {
            if (compares.HasAssKing_Suited(myCards))
            {
                return new Bet(table.minimumRaise * 2);
            }

            if (compares.HasAceKing_OffSuited(myCards))
            {
                return new Bet(table.minimumRaise * 2);
            }

            if (compares.HasAceJack_Suited(myCards))
            {
                return new Bet(table.minimumRaise * 2);
            }

            if (compares.HasAceQueen_suited(myCards))
            {
                return new Bet(table.minimumRaise * 2);
            }


            return new Bet(table.minimumRaise);
        }

        // Paar
        if (compares.HasPair(numericAllCards) > 0)
        {
            return new Bet(table.minimumRaise);
        }

        // Ass King gleichfarbig
        if (compares.HasAssKing_Suited(myCards))
        {
            return new Bet(table.minimumRaise);
        }

        // Ass King anderer Farben
        if (compares.HasAceKing_OffSuited(myCards))
        {
            return new Bet(table.minimumRaise);
        }

        // Ass Bube gleichfarbig
        if (compares.HasAceJack_Suited(myCards))
        {
            return new Bet(table.minimumRaise);
        }

        // Ass Dame gleichfarbig
        if (compares.HasAceQueen_suited(myCards))
        {
            return new Bet(table.minimumRaise);
        }


        if (compares.HasKingQueen_suited(myCards))
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