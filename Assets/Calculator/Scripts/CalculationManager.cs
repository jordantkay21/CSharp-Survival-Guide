using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationManager : MonoSingleton<CalculationManager>
{
    private string _num1String;
    private float _num1;
    private string _num2String;
    private float _num2;
    private string _chosenOperator;

    private float _result;
    private bool _operatorChosen;

    public void FillNum(string newValue) 
    {
        if(_operatorChosen == true && _num2String != null)
        {
            _num1 = float.Parse(_num1String, System.Globalization.NumberStyles.Number);
            _num2 = float.Parse(_num2String, System.Globalization.NumberStyles.Number);
            SolveEquation(_num1, _num2);
            _num1 = _result;
            _num2String += newValue;
        }
        else if(_operatorChosen == true && _num2String == null)
        {
            _num2String += newValue;
        }
        else if(_operatorChosen == false)
        {
            _num1String += newValue;
        }
    }

    public void SetOperator(string chosenOperator)
    {
        _operatorChosen = true;
        _chosenOperator = chosenOperator;
    }

    private void SolveEquation(float num1, float num2)
    {
        switch(_chosenOperator)
        {
            case "+":
                _result = num1 + num2;
                break;
            case "-":
                _result = num1 - num2;
                break;
            case "x":
                _result = num1 * num2;
                break;
            case "/":
                _result = num1 / num2;
                break;

        }
    }
}
