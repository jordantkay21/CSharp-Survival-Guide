using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
    private GameObject _cube;
    private Color _color;
    private Color _previousColor;
    
    /// <summary>
    /// Constructor to populate information for our raycast
    /// </summary>
    /// <param name="cube"> Cube GameObject our Raycast hits</param>
    /// <param name="color">The Color our cube will change to</param>
    public ClickCommand(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }

    /// <summary>
    /// Function that will run when user left clicks (Change cube to random color)
    /// </summary>
    public void Execute()
    {
        _previousColor = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    /// <summary>
    /// Function to change cube back to the previous color
    /// </summary>
    public void Undue()
    {
        _cube.GetComponent<MeshRenderer>().material.color = _previousColor;
    }
}
