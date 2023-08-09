using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.XR;

public class bowlCollider : MonoBehaviour 
{
    //[SerializeField] private GameObject blackscreen;
    [SerializeField] private GameObject winnerscreen;


    //[SerializeField] public GameObject ball;

    private int numberOfBalls;

    //private bool playerEntered;


    void Start()
	{
        numberOfBalls = 0;


    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("ball"))		//player has collided with trigger
		{
            other.gameObject.SetActive(false);
            //GameObject.Find("ButtonCont").SetActive(false);
            if (numberOfBalls==2)
            {
                winnerscreen.SetActive(true);
            }
            else
            {
                numberOfBalls++;
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
