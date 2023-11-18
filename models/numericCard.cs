namespace client_dotnet.models;

public class NumericCard
{
    public int numRank;
    public Suit numSuit;
    

    public NumericCard(int numRank, Suit numSuit)
    {
        this.numRank = numRank;
        this.numSuit = numSuit;
    }


    public static NumericCard[] TransformCards(Card[] allCards)
    {
        NumericCard[] result = Array.Empty<NumericCard>();

        foreach (var card in allCards)
        {
            result.Append(new NumericCard(card.Val(), card.suit));
        }
        Debug(result);
        return result;
    }

    public static void Debug(NumericCard[] res)
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
