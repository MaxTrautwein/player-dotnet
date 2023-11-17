using client_dotnet.models;

namespace client_dotnet.logic;

public class compares
{
    public static int HasPair(numericCard[] allNumericCards)
    {
        int highestPair = 0;
        int numPairs = 0;
        
        
        for (int i = 0; i < allNumericCards.Length; i++)
        {
            
            for (int j = i+1; j < allNumericCards.Length; j++)
            {
                
                if (allNumericCards[i]==allNumericCards[j] )
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


    }
}