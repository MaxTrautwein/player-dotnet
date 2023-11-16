using client_dotnet.models;

namespace client_dotnet.logic;

public class compares
{
    public static int HasPair(numericCard[] all)
    {
        int highestPair = 0;
        int numPairs = 0;
        
        
        for (int i = 0; i < all.Length; i++)
        {
            
            for (int j = i+1; j < all.Length; j++)
            {
                
                if (all[i]==all[j] )
                {
                    numPairs++;
                    if (all[i].numRank > highestPair)
                    {
                        highestPair = all[i].numRank;
                        
                    }
                    
                }
            }
            
        }

        return highestPair + 14;


    }
}