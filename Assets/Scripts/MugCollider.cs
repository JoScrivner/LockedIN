using UnityEngine;
using System.Collections;
using TMPro;

public class MugCollider : MonoBehaviour 
{
    [SerializeField] private GameObject blackscreen;
    [SerializeField] private GameObject cluescreen;

    public HelpingClues clues;

    //[SerializeField] public GameObject drawer;


    //private bool playerEntered;


    void Start()
	{



    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("Mug"))		//player has collided with trigger
		{
            AudioManagerScript.PlaySound("computerOn");

            //GameObject.Find("ButtonCont").SetActive(false);
            blackscreen.SetActive(false);
            cluescreen.SetActive(true);
            clues.mugClue = true;

        }
    }
/*
	void OnTriggerExit(Collider other)
	{
        if (other.gameObject.CompareTag("Player"))       //player has collided with trigger
        {
            anim.SetBool("handEntered", false);

        }
    }*/



}
