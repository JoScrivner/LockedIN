using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TMPro;
using UnityEngine;

public class HelpingClues : MonoBehaviour
{
    public bool mugClue = false;
    public bool screwClue = false;
    public bool globeClue = false;
    public bool colorClue = false;

    public TextMeshProUGUI clueText;

    [SerializeField] private GameObject clueScreen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!mugClue)
        {
            clueText.text = "Try placing the mug on the coaster";
        }
        else if (!screwClue)
        {
            clueText.text = "Are you sure you have removed ALL screws you can find in the office?";
        }
        else if (!globeClue)
        {
            clueText.text = "Investigate the interactable objects in the office to find the name of Larry Dixon's company";
        }
        else if (!colorClue)
        {
            clueText.text = "Place the colored blocks on the shelf in the correct order";
        }
        else
        {
            clueText.text = "Follow the instructions of the voicemail and then leave the office before Mr. Dixon returns! Hint: Have you found the hidden gem within the secret room yet?";
        }


    }

    public void showClue()
    {
        clueScreen.SetActive(true);
    }

    public void hideClue()
    {
        clueScreen.SetActive(false);
    }
}
