using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public string value;

    public void AddValue()
    {
        CalculationManager.Instance.FillNum(value);
    }

    public void AddOperator()
    {
        CalculationManager.Instance.SetOperator(value);
    }
}
