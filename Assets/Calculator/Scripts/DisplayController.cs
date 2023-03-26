using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayController : MonoSingleton<DisplayController>
{
    public override void Init()
    {
        base.Init();
    }

    private Text displayText;

    private void Start()
    {
        displayText = GameObject.Find("DisplayText").GetComponent<Text>();
    }

    /// <summary>
    /// Sets the DisplayText to an empty string
    /// </summary>
    public void ClearDisplay()
    {
        displayText.text = "";
    }

    /// <summary>
    /// Adds text to the end of the display
    /// </summary>
    /// <param name="newText">Button Value</param>
    public void UpdateDisplayText(string newText)
    {
        displayText.text += newText;
    }
    /// <summary>
    /// displays the answer to the equation
    /// </summary>
    public void DisplayAnswer()
    {

    }


}
