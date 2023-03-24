public class Orc
{
    public static int TotalOrcs = 0;
    public static int TotalGold = 0;

    private int gold;

    public int Gold
    {
        get { return gold; }
        set
        {
            TotalGold += value - gold;
            gold = value;
        }
    }

    public Orc()
    {
        TotalOrcs++;
        Gold = 0;
        if (TotalOrcs > 5)
        {
            TotalGold -= 2;
            Gold += 2;
        }
        else
        {
            Gold += 2;
        }
    }
}
