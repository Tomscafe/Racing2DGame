using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBurtton : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("RacingGame");
    }

    public void GameExit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        // Application.Quit();
    }
}
