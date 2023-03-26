using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Stack.Pop
{
public class Pop : MonoBehaviour
{
        Stack<int> myStack = new Stack<int>();

    // Start is called before the first frame update
    void Start()
    {
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
    }

    // Update is called once per frame
    void Update()
    {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Debug.Log("Number of elements in Stack: " + myStack.Count);

                while(myStack.Count > 0)
                {
                    Debug.Log(myStack.Pop());
                }
            }   
    }
}

}

