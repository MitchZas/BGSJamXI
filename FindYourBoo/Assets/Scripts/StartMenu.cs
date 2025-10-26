using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    
    public void LoadOptions()
    {
        // TODO: Add back in when we have options
        //SceneManager.LoadScene();
        Debug.Log("Loading Options");
    }

    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("Quitting Game");
    }

    public void CreditsScreen()
    {
        SceneManager.LoadScene(3);
    }
}
