using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public Text highScoreText;
    public static int highScore;
    
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();    
    }



    void Update(){

        int highScore = Score.coinAmount;
        
        if(Score.coinAmount > PlayerPrefs.GetInt("HighScore", 0))
        {
           
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = Score.coinAmount.ToString();
        }
        
    }
}
