using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int coinAmount;
    Text coinScore;
 

    void Start()
    {
        coinScore = GetComponent<Text>();
    }
    void Update() 
    {
        coinScore.text = coinAmount.ToString();
        
        
    }
    
    

}
