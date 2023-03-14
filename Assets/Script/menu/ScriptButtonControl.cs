using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptButtonControl : MonoBehaviour
{
    public void btnStartStage(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void btnExitGame()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
