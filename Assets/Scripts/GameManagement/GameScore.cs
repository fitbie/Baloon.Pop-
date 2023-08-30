using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore
{
    public static int Score { get; private set; }



    public static void ModifyScore(int value)
    {
        Score += value;
        Debug.Log(Score);
    }
}
