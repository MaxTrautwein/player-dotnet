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
                break;
            case Rank.K:
                return 13;
                break;
            case Rank.Q:
                return 12;
                break;
            case Rank.J:
                return 11;
                break;
            case Rank._10:
                return 10;
                break;
            case Rank._9:
                return 9;
                break;
            case Rank._8:
                return 8;
                break;
            case Rank._7:
                return 7;
                break;
            case Rank._6:
                return 6;
                break;
            case Rank._5:
                return 5;
                break;
            case Rank._4:
                return 4;
                break;
            case Rank._3:
                return 3;
                break;
            case Rank._2:
                return 2;
                break;
            default:
                
                throw new ArgumentOutOfRangeException(nameof(rank), rank, this.rank.ToString());
        }

        return 0;
    }

    
}

