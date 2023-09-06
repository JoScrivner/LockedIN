using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{

    [SerializeField] private GameObject ContinueToStory; //introduction2
    [SerializeField] private GameObject GoToGame; //guidedbutton
    [SerializeField] private GameObject GoToPractice; //interactivebutton


    [SerializeField] private GameObject enterGameButton;
    [SerializeField] private GameObject enterGameText;

    [SerializeField] private GameObject enterPracticeButton;
    [SerializeField] private GameObject enterPracticeText;


    // Start is called before the first frame update
    void Start()
    {
        //m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnContinuePressed()
    {
        GameObject.Find("ButtonCont").SetActive(false);
        GameObject.Find("Introduction").SetActive(false);


        ContinueToStory.SetActive(true);
        GoToGame.SetActive(true);
        GoToPractice.SetActive(true);


    }

    public void OnEnterPressed()
    {
        ContinueToStory.SetActive(false);
        GoToGame.SetActive(false);
        GoToPractice.SetActive(false);


        enterGameButton.SetActive(true);
        enterGameText.SetActive(true);

    }

    public void OnPracticePressed()
    {
        ContinueToStory.SetActive(false);
        GoToGame.SetActive(false);
        GoToPractice.SetActive(false);


        enterPracticeButton.SetActive(true);
        enterPracticeText.SetActive(true);

    }

    /*public void OnStartGuidedButton()
    {
        //Debug.Log("Main button is working");
        GameObject.Find("MenuCanvas").SetActive(false);
        medRoomLight.intensity = 0.5f;
        anim.SetBool("meditationStarting", true);

    }

    public void OnStartInteractiveButton()
    {
        GameObject.Find("MenuCanvas").SetActive(false);
        medRoomLight.intensity = 0.1f;
        //anim.SetBool("meditationStarting", true);

    }*/
}
