using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class openDoorEnd : MonoBehaviour
{

    [SerializeField] private GameObject winScreen;

    [SerializeField] private GameObject notYetText;
    [SerializeField] private GameObject buttonContGame;

    [SerializeField] private GameObject youWonText;
    [SerializeField] private GameObject buttonStartAgain;

    [SerializeField] private Animator anim;

    public bool gameWon;
    public countDownScript countdownclock;

    public TextMeshProUGUI TimerTxt;


    public ScaleCheck isItDone;
    public TextMeshProUGUI textResult;



    void Start()
    {
        //key = GameObject.FindGameObjectWithTag("ExitKey");

        //anim = GetComponent<Animator>(); 

        anim.SetBool("youWon", false);

        gameWon = false;


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ExitKey"))	     //player has collided with trigger
        {
            AudioManagerScript.PlaySound("keyInLock");


            showWin();

        }
    }


    public void showWin()
    {
        if(isItDone.isDone)
        {
            //clock.SetActive(false);
            gameWon = true;

            /*float timeLeft = 1800 - countdownclock.finalTime;
            float minutes = Mathf.FloorToInt(timeLeft / 60);
            float seconds = Mathf.FloorToInt(timeLeft % 60);*/

            //TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            textResult.text = "Congratulations, you did it!\n \nYou got out with " + TimerTxt.text + " left.\n \n Do you want to try again?";

            notYetText.SetActive(false);
            buttonContGame.SetActive(false);
            youWonText.SetActive(true);
            buttonStartAgain.SetActive(true);
            winScreen.SetActive(true);
            anim.SetBool("youWon", true);

            AudioManagerScript.PlaySound("youWon");

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
