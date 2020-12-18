using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausebutton : MonoBehaviour
{

    public GameObject pause;


    public void PauseGame(){
        pause.SetActive(true);
    }
    public void Resume()
    {
       pause.SetActive(false);
    }
   
}
