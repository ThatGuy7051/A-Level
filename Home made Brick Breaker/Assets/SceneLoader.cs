using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScenePosition()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(currentSceneIndex);
    }

     public void LoadStartScene()
     {
         SceneManager.LoadScene(0);
     }

     public void LoadSettingsScene()
     {
         SceneManager.LoadScene(1);
     }
     public void LoadPauseScene()
     {
         SceneManager.LoadScene(2);
     }
     public void LoadMultiplayerScene()
     {
         SceneManager.LoadScene(3);
     }
     public void LoadLeaderboardScene()
     {
         SceneManager.LoadScene(4);
     }
    public void QuitGame()
    {
        Application.Quit();
    }

}