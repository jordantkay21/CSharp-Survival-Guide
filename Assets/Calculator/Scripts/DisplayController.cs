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

    private TextMeshProUGUI displayText;
    private string _equation = "";

    private void Start()
    {
        displayText = GameObject.Find("DisplayText").GetComponent<TextMeshProUGUI>();
    }

    /// <summary>
    /// Sets the DisplayText to an empty string
    /// </summary>
    public void ClearDisplay()
    {
        displayText.SetText("");
    }

    /// <summary>
    /// Adds text to the end of the display
    /// </summary>
    /// <param name="newText">Button Value</param>
    public void UpdateDisplayText(string newText)
    {
        _equation += newText;
        displayText.SetText(_equation);
    }
    /// <summary>
    /// displays the answer to the equation
    /// </summary>
    public void DisplayAnswer()
    {

    }


}
