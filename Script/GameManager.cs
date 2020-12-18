using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{   
    public GameObject pause;
    public GameObject gameOverCanvas;
    

    private void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
   
   public void Replay()
   {
       SceneManager.LoadScene(1);
       Score.coinAmount = 0;
       
   }

    public void PauseGame(){
        pause.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
       pause.SetActive(false);
       Time.timeScale = 1;
    }
   
   public void BacktoMenu()
   {
  
    SceneManager.LoadScene(0);
   }

   
}
