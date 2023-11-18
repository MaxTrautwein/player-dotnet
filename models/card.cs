public class Card
{
    public Rank rank;
    public Suit suit;

    public int Val()
    {
        switch (this.rank)
        {
            case (Rank)'A':
                return 14;
            
            case (Rank)'K':
                return 13;
            
            case (Rank)'Q':
                return 12;
            
            case (Rank)'J':
                return 11;
            
            case (Rank)'T':
                return 10;
            
            case (Rank)9:
                return 9;
            
            case (Rank)8:
                return 8;
            
            case (Rank)7:
                return 7;
            
            case (Rank)6:
                return 6;
            
            case (Rank)5:
                return 5;
            
            case (Rank)4:
                return 4;
            
            case (Rank)3:
                return 3;
            
            case (Rank)2:
                return 2;
            
            default:
                throw new ArgumentOutOfRangeException(nameof(rank), rank, null);
        }
    }
}