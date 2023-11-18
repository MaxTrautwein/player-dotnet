public class Card
{
    public Rank rank;
    public Suit suit;
    
    public int Val()
    {
        switch (this.rank)
        {
            case Rank.A:
                return 14;
            case Rank.K:
                return 13;
            case Rank.Q:
                return 12;
            case Rank.J:
                return 11;
            case Rank._10:
                return 10;
            case Rank._9:
                return 9;
            case Rank._8:
                return 8;
            case Rank._7:
                return 7;
            case Rank._6:
                return 6;
            case Rank._5:
                return 5;
            case Rank._4:
                return 4;
            case Rank._3:
                return 3;
            case Rank._2:
                return 2;
            default:
                throw new ArgumentOutOfRangeException(nameof(rank), rank, null);
        }
    }

    
}

