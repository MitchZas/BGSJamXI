using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(WaitForIntro());
    }

    public void InitialPlayGame()
    {
        SceneManager.LoadScene(5);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
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
        SceneManager.LoadScene(2);
    }

    IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(37);
        SceneManager.LoadScene(1);
    }

}
