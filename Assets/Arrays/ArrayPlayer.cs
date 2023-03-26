using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArrayPlayer : MonoBehaviour
{
    public GameObject[] cubes;

    public void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            foreach(GameObject cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }

  
    }

    ///<summary>
    ///This function adds two numbers
    /// </summary>
    /// <param name="x"> Whole Number One </param>
    /// <param name="y"> Whole Number Two </param>
    public void AddTwoNumbers(int x, int y)
    {

    }

    
}
