using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private AudioSource buttonClick;

    private void Awake() {
        buttonClick = GetComponent<AudioSource>();
    }
    public void PlayButtonClicked(){
        PlayButtonAudio();
        Invoke("Play",buttonClick.clip.length);
    }
    public void RePlayButtonClicked(){
        PlayButtonAudio();
        Invoke("Replay",buttonClick.clip.length);
    }
    public void QuitButtonClicked(){
        PlayButtonAudio();
        Invoke("Quit",buttonClick.clip.length);
    }
    private void PlayButtonAudio(){
        buttonClick.Play();
    }
    private void Play(){
        SceneManager.LoadScene("Game");
    }
    private void Replay(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
   private void Quit(){
    Application.Quit();
   }
}
