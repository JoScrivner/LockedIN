using UnityEngine;
using System.Collections;
using TMPro;

public class ColorCollider : MonoBehaviour 
{
    public int blue;
    public int orange;
    public int red;
    public int green;
    public int yellow;

    [SerializeField] private Animator anim;

    [SerializeField] private GameObject teleportblocker;

    [SerializeField] private GameObject doorLock;



    public bool hasRun = false;

    //private bool playerEntered;
    public HelpingClues clues;


    void Start()
	{
        blue = 0;
        orange = 0;
        red = 0;
        green = 0;
        yellow = 0;

        anim.SetBool("wallTriggered", false);


    }

    /*void Count()
    {
        if ((blue + orange + red + green + yellow) == 5)
        {
            anim.SetBool("wallTriggered", true);
            hasRun = true;
        }
    }*/

    void Update()
    {
        if(hasRun == false && (blue + orange + red + green + yellow) == 5)
        {
            AudioManagerScript.PlaySound("success");
            teleportblocker.SetActive(false);
            hasRun = true;
            AudioManagerScript.PlaySound("wallMove");
            anim.SetBool("wallTriggered", true);
            clues.colorClue = true;
            doorLock.SetActive(true);

        }

    }



}
