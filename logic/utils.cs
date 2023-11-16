namespace client_dotnet.logic;

public class GameUtils
{
    public static bool HasSimilarRanks(Player player)
    {
        if (player?.cards == null || player.cards.Length < 2)
            return false;

        for (int i = 0; i < player.cards.Length; i++)
        {
            for (int j = i + 1; j < player.cards.Length; j++)
            {
                if (player.cards[i].rank == player.cards[j].rank)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool HasSimilarSuits(Player player)
    {
        if (player?.cards == null || player.cards.Length < 2)
            return false;

        for (int i = 0; i < player.cards.Length; i++)
        {
            for (int j = i + 1; j < player.cards.Length; j++)
            {
                if (player.cards[i].suit == player.cards[j].suit)
                {
                    return true;
                }
            }
        }

        return false;
    }
}