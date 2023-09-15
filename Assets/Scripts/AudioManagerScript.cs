using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public static AudioClip closetSound, colorSound, computerSound, drawerSound, phoneSound, screwSound, successSound, wallSound, youWonSound, keySound;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        closetSound = Resources.Load<AudioClip>("closetOpenSound");
        colorSound = Resources.Load<AudioClip>("colorPanelCollide");
        computerSound = Resources.Load<AudioClip>("computerOnSound");
        drawerSound = Resources.Load<AudioClip>("drawerOpenSound");

        phoneSound = Resources.Load<AudioClip>("phoneButtonClick");
        screwSound = Resources.Load<AudioClip>("screwRemoveSound2");
        successSound = Resources.Load<AudioClip>("successSound");
        wallSound = Resources.Load<AudioClip>("wallMoveSound");

        youWonSound = Resources.Load<AudioClip>("congrats");
        keySound = Resources.Load<AudioClip>("cannotUnlock");


        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "closetOpen":
                /*audioSource.volume = 1f;
                audioSource.pitch = 1f;*/
                audioSource.PlayOneShot(closetSound);
                break;
            case "colorCollide":
                audioSource.PlayOneShot(colorSound);
                break;
            case "computerOn":
                audioSource.volume = 0.7f;

                audioSource.PlayOneShot(computerSound);
                break;
            case "drawerOpen":
                audioSource.PlayOneShot(drawerSound);
                break;
            case "phoneClick":
                audioSource.volume = 0.4f;
                audioSource.PlayOneShot(phoneSound);
                break;
            case "screwRemoved":
                audioSource.PlayOneShot(screwSound);
                break;
            case "success":
                audioSource.volume = 0.7f;
                audioSource.PlayOneShot(successSound);
                break;
            case "wallMove":
                audioSource.PlayOneShot(wallSound);
                break;
            case "keyInLock":
                audioSource.PlayOneShot(keySound);
                break;
            case "youWon":
                audioSource.PlayOneShot(youWonSound);
                break;

        }
    }
}
