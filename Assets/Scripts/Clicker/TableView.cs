using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableView : MonoBehaviour
{
    private TableModel model;
    private Text textScore;

    private void Awake()
    {
        model = GetComponent<TableModel>();
        textScore = GetComponent<Text>();
    }

    public void UpdateTable()
    {
        textScore.text = model.Score.ToString();
    }
    

}
