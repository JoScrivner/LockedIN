using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoorEnd : MonoBehaviour
{
    //[SerializeField] private Animator anim;
    //private GameObject key;

    //[SerializeField] public Rigidbody key;

    //private bool playerEntered;

    [SerializeField] private GameObject winScreen;

    [SerializeField] private GameObject notYetText;
    [SerializeField] private GameObject buttonContGame;

    [SerializeField] private GameObject youWonText;
    [SerializeField] private GameObject buttonStartAgain;


    public ScaleCheck isItDone;



    void Start()
    {
        //key = GameObject.FindGameObjectWithTag("ExitKey");

        //anim = GetComponent<Animator>(); 
        //anim.SetBool("handEntered", false);


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ExitKey"))	     //player has collided with trigger
        {
            //anim.SetBool("handEntered", true);
            //AudioManagerScript.PlaySound("drawerOpen");
            showWin();

            //StartCoroutine(ExecuteAfterTime(1.1f));
        }
    }


    public void showWin()
    {
        if(isItDone.isDone)
        {
            notYetText.SetActive(false);
            buttonContGame.SetActive(false);
            youWonText.SetActive(true);
            buttonStartAgain.SetActive(true);
            winScreen.SetActive(true);
        }
        else
        {
            youWonText.SetActive(false);
            buttonStartAgain.SetActive(false);
            notYetText.SetActive(true);
            buttonContGame.SetActive(true);
            winScreen.SetActive(true);
        }

    }

    public void hideWin()
    {
        winScreen.SetActive(false);
    }

    /*IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        ballBody.isKinematic = false;
        //notebookBody.isKinematic = false;


        // Code to execute after the delay
    }*/
}
