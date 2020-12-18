using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip wingsFlapSound, gameOverSfxSound, venusChompSound, coinSound, birdFallSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        wingsFlapSound = Resources.Load<AudioClip>("wingsFlap");
        gameOverSfxSound = Resources.Load<AudioClip>("gameOverSfx");
        venusChompSound = Resources.Load<AudioClip>("venusChomp");
        coinSound = Resources.Load<AudioClip>("coin");
        birdFallSound = Resources.Load<AudioClip>("birdFall");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "wingsFlap":
                audioSrc.PlayOneShot(wingsFlapSound);
                break;
            case "gameOverSfx":
                audioSrc.PlayOneShot(gameOverSfxSound);
                break;
            case "venusChomp":
                audioSrc.PlayOneShot(venusChompSound);
                break;
            case "coin":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "birdFall":
                audioSrc.PlayOneShot(birdFallSound);
                break;
        }
    }
}
