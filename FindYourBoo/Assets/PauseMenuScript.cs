using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public static bool _gameIsPaused = false;
    public GameObject _pauseMenuUI;

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

    void Resume()
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
}
