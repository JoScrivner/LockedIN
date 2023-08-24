using UnityEngine;
using System.Collections;
using TMPro;

public class OrangeCollider : MonoBehaviour 
{
    public ColorCollider checkColor;


    void Start()
	{



    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("orange"))		//player has collided with trigger
		{
            checkColor.orange = 1;


        }
    }

	void OnTriggerExit(Collider other)
	{
        if (other.gameObject.CompareTag("orange"))        //player has collided with trigger
        {
            checkColor.orange = 0;

        }
    }



}
