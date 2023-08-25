using UnityEngine;
using System.Collections;
using TMPro;

public class YellowCollider : MonoBehaviour 
{
    public ColorCollider checkColor;


    void Start()
	{



    }

    void OnTriggerEnter(Collider other)
	{
        AudioManagerScript.PlaySound("colorCollide");

        if (other.gameObject.CompareTag("yellow"))		//player has collided with trigger
		{
            checkColor.yellow = 1;


        }
    }

	void OnTriggerExit(Collider other)
	{
        if (other.gameObject.CompareTag("yellow"))        //player has collided with trigger
        {
            checkColor.yellow = 0;

        }
    }



}
