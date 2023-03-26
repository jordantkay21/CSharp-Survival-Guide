using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    #region LevelSelector
    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public LevelSelector currentLevel;

    private void Update()
    {
        switch (currentLevel)
        {
            case LevelSelector.Easy:
                Debug.Log("You selected Easy!");
                break;

            case LevelSelector.Normal:
                Debug.Log("You selected Normal!");
                break;

            case LevelSelector.Hard:
                Debug.Log("You selected Hard!");
                break;

            case LevelSelector.Expert:
                Debug.Log("You selected Expert!");
                break;
        }
    }

    #endregion

    #region SceneSelector

    public enum SceneSelector
    {
        LevelOne,
        LevelTwo,
        LevelThree,
        LevelFour,
        LevelFive
    }

    public SceneSelector selectedScene;

    private void Start()
    {
        SceneManager.LoadScene((int)selectedScene);
    }


    #endregion
}
