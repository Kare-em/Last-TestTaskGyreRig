using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private Button button;
    private TableController tableController;
    private ButtonModel model;
    private ButtonView view;
    // Start is called before the first frame update
    private void Awake()
    {
        tableController = FindObjectOfType<TableController>();
        model = GetComponent<ButtonModel>();
        view = GetComponent<ButtonView>();
        button = GetComponent<Button>();

    }
    private void Start()
    {
        view.SetText(model.HeaderText);
        button.onClick.AddListener(SendScore);
    }
    private void SendScore()
    {
        tableController.ChangeScore(model.ScoreValue);
    }

}
