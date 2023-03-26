using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public string value;
    
    /// <summary>
    /// add the value of this button to the displayText
    /// </summary>
    public void AddValueToDisplay()
    {
        DisplayController.Instance.UpdateDisplayText(value);
    }
    /// <summary>
    /// Display answer method
    /// </summary>
    public void EvaluateEquation()
    {
        DisplayController.Instance.DisplayAnswer();
    }
    /// <summary>
    /// Clear the DisplayText
    /// </summary>
    public void Clear()
    {
        DisplayController.Instance.ClearDisplay();
    }
}
