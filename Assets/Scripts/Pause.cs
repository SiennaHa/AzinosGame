//using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject window;

    public bool isPaused;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TogglePauseWindow(false);
        isPaused = false;
    }




    private void TogglePauseWindow(bool show)
    {
        Debug.Log("show/hide");
        window.SetActive(show);
    }

    public void PauseMenu(  )
    {
        TogglePauseWindow(true);
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
        isPaused = false;
    }
        public void Resume()
    {
        TogglePauseWindow(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

}
