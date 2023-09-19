using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class countDownScript : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public float finalTime;
    public openDoorEnd isTheGameWon;


    public TextMeshProUGUI TimerTxt;
    
    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTime(TimeLeft);
            }
            else
            {
                //Debug.Log("Time is UP!");
                TimeLeft = 0;
                TimerOn = false;
                SceneManager.LoadScene(2);

            }
        }
        if(isTheGameWon.gameWon)
        {
            finalTime = TimeLeft;
            TimerOn = false;
        }   
    }

    void updateTime(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
