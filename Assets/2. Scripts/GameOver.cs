using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("RestartMenu");
    }
}
