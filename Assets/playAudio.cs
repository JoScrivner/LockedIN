using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    public AudioSource soundPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playVoicemail()
    {
        AudioManagerScript.PlaySound("phoneClick");

        soundPlayer.Play();
    }
}
