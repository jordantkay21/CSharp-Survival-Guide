using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoBehaviour
{
    private static CommandManager _instance;
    public static CommandManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("The CommandManager is NULL.");

            return _instance;
        }
    }

    private List<ICommand> _commandBuffer = new List<ICommand>();

    private void Awake()
    {
        _instance = this;
    }

    /// <summary>
    /// Adds a commands to the _commandBuffer List
    /// </summary>
    /// <param name="command"></param>
    public void AddCommand(ICommand command)
    {
        _commandBuffer.Add(command);
        Debug.Log("Added Command, list is now at " + _commandBuffer.Count);
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
        Debug.Log("Play button is pressed");
    }

    /// <summary>
    /// Method to play through the _commandBuffer List
    /// </summary>
    /// <returns></returns>
    IEnumerator PlayRoutine()
    {
        Debug.Log("Playing...");

        foreach(ICommand command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("Finshed");
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }

    /// <summary>
    /// Method to play through the _commandBuffer in Reverse
    /// </summary>
    /// <returns></returns>
    IEnumerator RewindRoutine()
    {
        foreach(ICommand command in Enumerable.Reverse(_commandBuffer)) //Enumerable.Reverse is a LINQ concept
        {
            command.Undue();
            yield return new WaitForSeconds(1.0f);
        }
    }

    /// <summary>
    /// Changes all cubes back to white
    /// </summary>
    public void Done()
    {
        var cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach (var cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

    /// <summary>
    /// Clears out the _commandBuffer List
    /// </summary>
    public void Reset()
    {
        _commandBuffer.Clear();
    }


}
