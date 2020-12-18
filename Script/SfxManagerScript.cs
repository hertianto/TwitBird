using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManagerScript : MonoBehaviour
{
    public AudioSource buttonClick;

    public void PlaybuttonClick()
    {
        buttonClick.Play();
    }
}
