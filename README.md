# Gameclass24s
i will make game . 
downlaod asset
and working on enverment of game 



second task plan for game 
add main page.
the main page have  two button start game and exit game in main page 
give values to boxes or gift boxes


6/5/2024
will help me alot thank you so much for helping

update how  to set up in  agame main page or menu page 
fist  create a new scene
Go to  click right  on new scence  or  GameObject -> UI -> Canvas. This will also create an EventSystem
right click on canvas but it is opional to add panel or not we make on canvas 
Choose UI -> Button. This adds a button to your canvas if choose panel in canvas will add button in panel
Right-click in the Project window, select Create -> C# Script

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
  

 
