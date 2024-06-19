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

6/15
add audiosoure and also game has 10 obstcles each obstcle has deffernt jump value.if car teach or pump obstcle will jump  also some obstcles does not have any jump valu if car pump not show any rection
 this code 
  
 using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public float jumpForce = 2;// jump valu has deffernt in each obstcle
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // Optional: Check if audioSource is assigned
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is missing from this GameObject.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collided");

            // Play the collision sound
            if (audioSource != null)
            {
                audioSource.Play();
            }

            Rigidbody goRB = collision.gameObject.GetComponent<Rigidbody>();
            if (goRB != null)
            {
                goRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
