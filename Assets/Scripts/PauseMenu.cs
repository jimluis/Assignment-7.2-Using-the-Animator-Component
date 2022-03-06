using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool gamePaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        gamePaused = false;
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
    }

    void PauseGame()
    {
        gamePaused = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
    }

    public void LoadGameMenu()
    {
        Debug.Log("PauseMenu.LoadGameMenu() SceneManager.LoadScene(0) ");
        SceneManager.LoadScene(0);

    }
}
