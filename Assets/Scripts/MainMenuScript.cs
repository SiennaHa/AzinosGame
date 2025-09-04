using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] string sceneName; //name of scene

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadIce()
    {
        SceneManager.LoadScene("IceSkating");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
#else
        {
        Application.Quit();
        }
#endif

    }

}
