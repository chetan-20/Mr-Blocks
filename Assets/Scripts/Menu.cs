
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   
    [SerializeField] private AudioSource clicksound;

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        clicksound.Play();
    }
    public void QuitGame()
    {
        Application.Quit();
        clicksound.Play();
    }

    public void LoadMenu()
    {
       
        SceneManager.LoadScene(0);
        clicksound.Play();
       
    }
}
