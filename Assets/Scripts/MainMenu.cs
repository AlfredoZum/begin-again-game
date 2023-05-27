using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     public string level1SceneName;
   public void PlayGame ()
   {
        SceneManager.LoadScene(level1SceneName);
   }

   public void QuitGame ()
   {
        Application.Quit();
   }
}
