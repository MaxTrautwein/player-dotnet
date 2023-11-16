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


    public static numericCard[] TransformCards(Card[] allCards)
    {
        numericCard[] result = Array.Empty<numericCard>();

        foreach (var card in allCards)
        {
            result.Append(new numericCard(card.Val(), card.suit));
        }
        
        return result;
    }

    public static void debug(numericCard[] res)
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("------------------------------------------------------");

        foreach (var eintrag  in res)
        {
            Console.WriteLine(eintrag);
        }
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("------------------------------------------------------");
    }
}
