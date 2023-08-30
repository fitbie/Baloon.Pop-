using System.Collections.Generic;

public class CurrentBaloons
{
    public static List<BaloonBase> currentBaloons = new List<BaloonBase>();


    public static void AddBaloon(BaloonBase baloon)
    {
        currentBaloons.Add(baloon);
    }

    public static void RemoveBaloon(BaloonBase baloon)
    {
        currentBaloons.Remove(baloon);
    }
}
