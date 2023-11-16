namespace client_dotnet.models;

public class numericCard
{
    public int numRank;
    public Suit numSuit;
    

    public numericCard(int numRank, Suit numSuit)
    {
        this.numRank = numRank;
        this.numSuit = numSuit;
    }


    public numericCard[] Transformation(Card[] allCards)
    {
        numericCard[] result = null;

        foreach (var card in allCards)
        {
            result.Append(new numericCard(card.Val(), card.suit));
        }
        
        
        
        
        
        return result;
    }
}
