using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    
  public void StartGame()
    {
        SceneManager.LoadScene("ArchiveRoom");
    }

  
    public void QuitGame()
    {
        Application.Quit();
    }
}
