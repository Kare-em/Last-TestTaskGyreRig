using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    private TableModel model;
    private TableView view;

    void Start()
    {
        model = GetComponent<TableModel>();
        view = GetComponent<TableView>();
        model.Score = 0;
        view.UpdateTable();
    }

    public void ChangeScore(int newScore)
    {
        model.Score += newScore;
        view.UpdateTable();
    }

}
