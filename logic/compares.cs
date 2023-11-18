using client_dotnet.models;

namespace client_dotnet.logic;

public class compares
{
    public static int HasPair(NumericCard[] allNumericCards)
    {
        int highestPair = 0;
        int numPairs = 0;


        for (int i = 0; i < allNumericCards.Length; i++)
        {
            for (int j = i + 1; j < allNumericCards.Length; j++)
            {
                if (allNumericCards[i] == allNumericCards[j])
                {
                    numPairs++;
                    if (allNumericCards[i].numRank > highestPair)
                    {
                        highestPair = allNumericCards[i].numRank;
                    }
                }
            }
        }

        return highestPair + 14;
        // wieso + 14 ???
    }

    public static bool HasAssKing_Suited(Card[] startingHand)
    {
        int valOne = startingHand[0].Val();
        int valTwo = startingHand[1].Val();

        if ((valOne == 14 && valTwo == 13) || (valOne == 13 && valTwo == 14))
        {
            if (startingHand[0].suit == startingHand[1].suit)
            {
                return true;
            }

            return false;
        }

        return false;
    }

    public static bool HasAceKing_OffSuited(Card[] startingHand)
    {
        int valOne = startingHand[0].Val();
        int valTwo = startingHand[1].Val();

        if ((valOne == 14 && valTwo == 13) || (valOne == 13 && valTwo == 14))
        {
            if (startingHand[0].suit != startingHand[1].suit)
            {
                return true;
            }

            return false;
        }

        return false;
    }


    public static bool HasAceJack_Suited(Card[] startingHand)
    {
        int valOne = startingHand[0].Val();
        int valTwo = startingHand[1].Val();

        if ((valOne == 14 && valTwo == 11) || (valOne == 11 && valTwo == 14))
        {
            if (startingHand[0].suit == startingHand[1].suit)
            {
                return true;
            }

            return false;
        }

        return false;
    }

    public static bool HasAceQueen_suited(Card[] startingHand)
    {
        int valOne = startingHand[0].Val();
        int valTwo = startingHand[1].Val();

        if ((valOne == 14 && valTwo == 12) || (valOne == 12 && valTwo == 14))
        {
            if (startingHand[0].suit == startingHand[1].suit)
            {
                return true;
            }

            return false;
        }

        return false;
    }
}