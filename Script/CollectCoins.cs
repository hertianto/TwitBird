using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
  

    private void OnTriggerEnter2D (Collider2D coin)
    {
        if(coin.gameObject.CompareTag("Player"))
        {
            SoundManagerScript.PlaySound("coin");
            Score.coinAmount += 1;
            Destroy(gameObject);
        }
    }
}
