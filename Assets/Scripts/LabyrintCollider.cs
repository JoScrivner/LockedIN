using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class LabyrintCollider : MonoBehaviour 
{


    [SerializeField] public GameObject gem;



    void Start()
	{



    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("realGem"))		//player has collided with trigger
		{
            gem.transform.SetParent(null);

        }
    }

}
