using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SCOREREAL : MonoBehaviour
{
   Text coinScore;
    public static int coinAmount;

    void Start() {
        coinAmount = 0;
        coinScore = GetComponent<Text> ();
        
    }

    void Update() {
        coinScore.text = coinAmount.ToString();
    }
}
