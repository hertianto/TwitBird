using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyLittleBird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb =  GetComponent<Rigidbody2D>();  
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SoundManagerScript.PlaySound("wingsFlap");
            //Jump
            rb.velocity = Vector2.up * velocity;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManagerScript.PlaySound("birdFall");
        SoundManagerScript.PlaySound("gameOverSfx");
        gameManager.GameOver();
    }
}



