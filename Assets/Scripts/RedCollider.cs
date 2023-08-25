using UnityEngine;
using System.Collections;
using TMPro;

public class RedCollider : MonoBehaviour 
{
    public ColorCollider checkColor;


    void Start()
	{



    }

    void OnTriggerEnter(Collider other)
	{
        AudioManagerScript.PlaySound("colorCollide");

        if (other.gameObject.CompareTag("red"))		//player has collided with trigger
		{
            checkColor.red = 1;


        }
    }

	void OnTriggerExit(Collider other)
	{
        if (other.gameObject.CompareTag("red"))        //player has collided with trigger
        {
            checkColor.red = 0;

        }
    }



}
