using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    
  public void ReturnGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

  
   public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}