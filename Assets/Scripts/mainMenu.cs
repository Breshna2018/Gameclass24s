using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {

        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying= false;

#endif
    }


    
}
