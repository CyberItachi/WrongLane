using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameController instance;
    public Scene game;
    
    private void Awake() {
        if(instance != null){
            Destroy(instance);
        }
        else{
            instance = this;
        }

        DontDestroyOnLoad(this);
    }

    public void Play(){
        SceneManager.LoadScene("Game");
    }
    public void Replay(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
   public void Quit(){
    Application.Quit();
   }
}
