using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
