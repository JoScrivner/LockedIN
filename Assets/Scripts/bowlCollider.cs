using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.XR;

public class bowlCollider : MonoBehaviour 
{
    //[SerializeField] private GameObject blackscreen;

    public ScaleCheck ScaleMath;


    //[SerializeField] public GameObject ball;

    //private int numberOfRealGems;

    //private bool playerEntered;


    void Start()
	{
        //numberOfRealGems = 0;


    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("realGem"))		//player has collided with trigger
		{
            //other.gameObject.SetActive(false);

            /*if (numberOfRealGems == 2)
            {
                winnerscreen.SetActive(true);
            }
            else
            {
                numberOfRealGems++;
            }*/

            ScaleMath.realGemNo++;


        }
        else if (other.gameObject.CompareTag("dragon"))
        {
            ScaleMath.dragonNo++;
        }
    }

	void OnTriggerExit(Collider other)
	{
        if (other.gameObject.CompareTag("realGem"))       //player has collided with trigger
        {
            ScaleMath.realGemNo--;

        }
        else if (other.gameObject.CompareTag("dragon"))
        {
            ScaleMath.dragonNo--;
        }
    }



}
