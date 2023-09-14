using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.XR;

public class screwDriverCollider : MonoBehaviour 
{
    [SerializeField] private GameObject paintingObject;
    [SerializeField] private GameObject panelObject;

    //[SerializeField] private GameObject winnerscreen;


    //[SerializeField] public GameObject ball;

    private int pictureScrews;
    private int panelScrews;
    private Rigidbody rb1;
    private Rigidbody rb2;

    public HelpingClues clues;

    //private bool playerEntered;


    void Start()
	{
        pictureScrews = 0;
        panelScrews = 0;

        rb2 = panelObject.GetComponent<Rigidbody>();
        rb1 = paintingObject.GetComponent<Rigidbody>();


    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("picScrew"))		//player has collided with trigger
		{
            AudioManagerScript.PlaySound("screwRemoved");

            other.gameObject.SetActive(false);
            //GameObject.Find("ButtonCont").SetActive(false);
            if (pictureScrews == 1)
            {
                rb1.isKinematic = false;
                //paintingObject.SetActive(true);
                clues.screwClue = true;

            }
            else
            {
                pictureScrews++;
            }
            
        }
        else if (other.gameObject.CompareTag("panelScrew"))       //player has collided with trigger
        {
            AudioManagerScript.PlaySound("screwRemoved");

            other.gameObject.SetActive(false);
            //GameObject.Find("ButtonCont").SetActive(false);
            if (panelScrews == 3)
            {
                rb2.isKinematic = false;
                //paintingObject.SetActive(true);
            }
            else
            {
                panelScrews++;
            }

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
