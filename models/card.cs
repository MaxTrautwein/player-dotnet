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
                Console.WriteLine("###########");
                Console.WriteLine(rank.ToString());
                if (rank == Rank._2) Console.WriteLine("2");
                if (rank == Rank._3) Console.WriteLine("3");
                if (rank == Rank._4) Console.WriteLine("4");
                if (rank == Rank._5) Console.WriteLine("5");
                if (rank == Rank._6) Console.WriteLine("6");
                if (rank == Rank._7) Console.WriteLine("7");
                if (rank == Rank._8) Console.WriteLine("8");
                if (rank == Rank._9) Console.WriteLine("9");
                if (rank == Rank._10) Console.WriteLine("10");
                if (rank == Rank.J) Console.WriteLine("11");
                if (rank == Rank.Q) Console.WriteLine("12");
                if (rank == Rank.K) Console.WriteLine("13");
                if (rank == Rank.A) Console.WriteLine("14");
                
                Console.WriteLine("###########");
                
                return 14;
               // throw new ArgumentOutOfRangeException(nameof(rank), rank, this.rank.ToString());
        }

        return 0;
    }

    
}

