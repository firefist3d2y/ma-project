using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void playMenu()
    {
        Debug.Log("playMenu");
        SceneManager.LoadScene("MainMenu");
    }

    public void level1()
    {
        Debug.Log("level1");
        SceneManager.LoadScene("Level1");
    }

    public void changeScene(string sceneName)
    {
        Debug.Log("change to: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
