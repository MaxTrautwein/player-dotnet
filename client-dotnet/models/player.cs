public enum PlayerStatusEnum
{
    ACTIVE = 'A',
    FOLDED = 'F',
    OUT = 'O'
}

public class Player
{
    public string name;
    public PlayerStatusEnum status;
    public int stack;
    public int bet;
    public Card[] cards;
}
