using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    public void SetText(string text)
    {
        GetComponentInChildren<Text>().text = text;
    }
}
