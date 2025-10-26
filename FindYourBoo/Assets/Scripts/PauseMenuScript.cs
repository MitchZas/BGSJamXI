using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public static bool _gameIsPaused = false;
    public GameObject _pauseMenuUI;
    public GameObject DialogueCloseCanvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        _pauseMenuUI.SetActive(false);

        Time.timeScale = 1f;
        _gameIsPaused = false;
    }

    void Pause()
    {
        _pauseMenuUI.SetActive(true);

        Time.timeScale = 0f;
        _gameIsPaused = true;
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

    public void CloseDialogueBox()
    {
        DialogueCloseCanvas.SetActive(false);
    }
}
