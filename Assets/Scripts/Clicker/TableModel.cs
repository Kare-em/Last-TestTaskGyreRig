using System;
using UnityEngine;

public class TableModel : MonoBehaviour
{
    private int score;

    public int Score
    {
        get => score;
        set
        {
            score = value;
            if (score < 0)
                throw new Exception("Invalid changes in Score");
        }
    }
}
