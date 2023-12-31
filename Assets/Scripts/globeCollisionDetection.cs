﻿using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.XR;

public class globeCollisionDetection : MonoBehaviour 
{
    //[SerializeField] private GameObject blackscreen;
    [SerializeField] private GameObject dot;
    [SerializeField] private Animator anim;

    public HelpingClues clues;


    //[SerializeField] public GameObject ball;

    //private int numberOfBalls;

    //private bool playerEntered;


    void Start()
	{
        //numberOfBalls = 0;
        anim.SetBool("closetTriggered", false);


    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("dotGlobe"))		//player has collided with trigger
		{
            AudioManagerScript.PlaySound("success");

            dot.gameObject.SetActive(true);
            anim.SetBool("closetTriggered", true);
            AudioManagerScript.PlaySound("closetOpen");
            clues.globeClue = true;


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
