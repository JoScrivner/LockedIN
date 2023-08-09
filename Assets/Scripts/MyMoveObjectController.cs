using UnityEngine;
using System.Collections;
using TMPro;

public class MyMoveObjectController : MonoBehaviour 
{
    [SerializeField] private Animator anim;
	private GameObject hand;

    [SerializeField] public Rigidbody ballBody;
    //[SerializeField] public Rigidbody notebookBody;



    //[SerializeField] public GameObject drawer;


    //private bool playerEntered;


    void Start()
	{
		hand = GameObject.FindGameObjectWithTag("Player");

        //anim = GetComponent<Animator>(); 
        anim.SetBool("handEntered", false);


    }

    void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.CompareTag("Player"))		//player has collided with trigger
		{
            anim.SetBool("handEntered", true);

            StartCoroutine(ExecuteAfterTime(1.1f));
        }
	}

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        ballBody.isKinematic = false;
        //notebookBody.isKinematic = false;


        // Code to execute after the delay
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
