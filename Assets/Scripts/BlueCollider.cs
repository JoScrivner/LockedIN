using UnityEngine;
using System.Collections;
using TMPro;

public class BlueCollider : MonoBehaviour 
{
    public ColorCollider checkColor;


    void Start()
	{



    }

    void OnTriggerEnter(Collider other)
	{
        AudioManagerScript.PlaySound("colorCollide");

        if (other.gameObject.CompareTag("blue"))		//player has collided with trigger
		{
            checkColor.blue = 1;


        }
    }

	void OnTriggerExit(Collider other)
	{
        if (other.gameObject.CompareTag("blue"))        //player has collided with trigger
        {
            checkColor.blue = 0;

        }
    }



}
