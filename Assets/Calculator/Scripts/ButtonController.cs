using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public string value;


    /// <summary>
    /// Pushes value of numerical button pressed to the equation 
    /// </summary>
    public void AddValue()
    {
        CalculationManager.Instance.FillNum(value);
        DisplayManager.Instance.UpdateDisplayText(value);
    }
    /// <summary>
    /// Pushes value of operator button pressed to the equation
    /// </summary>
    public void AddOperator()
    {
        CalculationManager.Instance.SetOperator(value);
        DisplayManager.Instance.UpdateDisplayText(value);
    }
    /// <summary>
    /// Pushes value of CLEAR button pressed to Managers
    /// </summary>
    public void Clear()
    {
        CalculationManager.Instance.ClearCalculator();
        DisplayManager.Instance.ClearDisplay();
        
    }
    /// <summary>
    /// Pushes value of EQUALS button pressed to Managers
    /// </summary>
    public void SolveEquation()
    {
        CalculationManager.Instance.EqualsPressed();
    }
}
