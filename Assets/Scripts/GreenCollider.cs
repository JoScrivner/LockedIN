using UnityEngine;
using System.Collections;
using TMPro;

public class GreenCollider : MonoBehaviour 
{
    public ColorCollider checkColor;


    void Start()
	{



    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("green"))		//player has collided with trigger
		{
            checkColor.green = 1;


        }
    }

	void OnTriggerExit(Collider other)
	{
        if (other.gameObject.CompareTag("green"))        //player has collided with trigger
        {
            checkColor.green = 0;

        }
    }



}
