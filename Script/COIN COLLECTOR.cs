using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COINCOLLECTOR : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.gameObject.tag == "Coin") {
            Score.coinAmount += 1;
            Destroy(collision.gameObject);
        }
    }
}
