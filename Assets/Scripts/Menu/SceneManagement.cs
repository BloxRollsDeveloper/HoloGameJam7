using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    
  public void StartGame()
    {
        SceneManager.LoadScene("BootlegArchiveRoom");
    }

  
   public void QuitGame()
    {
        Application.Quit();
    }
}
