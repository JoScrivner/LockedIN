using UnityEngine;
using System.Collections;
using TMPro;

public class LabyrintCollider : MonoBehaviour 
{
    //[SerializeField] private GameObject blackscreen;
    //[SerializeField] private GameObject cluescreen;


    [SerializeField] public GameObject ball;


    //private bool playerEntered;


    void Start()
	{



    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("ball"))		//player has collided with trigger
		{
            //GameObject.Find("ButtonCont").SetActive(false);
            ball.transform.SetParent(null);


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
