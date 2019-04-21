using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    private Text debugText = null;

    public void BindUI(Text debugText)
    {
        this.debugText = debugText;
    }

    public void Display(params string[] messages)
    {
        debugText.text = string.Empty;
        foreach(string message in messages)
        {
            debugText.text += $"{message} \n";
        }
    }
}
