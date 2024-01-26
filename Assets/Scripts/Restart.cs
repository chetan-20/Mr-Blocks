
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    [SerializeField] private AudioSource clicksound;

    public void RestartLevel()
    {
        
        clicksound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
       
    }


}
