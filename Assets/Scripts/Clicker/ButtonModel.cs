using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonModel : MonoBehaviour
{
    [SerializeField] string headerText;
    [SerializeField] private int scoreValue;
    public string HeaderText { get => headerText; }
    public int ScoreValue { get => scoreValue; }
}
