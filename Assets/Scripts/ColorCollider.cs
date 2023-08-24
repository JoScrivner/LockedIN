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

    public bool hasRun = false;

    //private bool playerEntered;


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
            hasRun = true;

            anim.SetBool("wallTriggered", true);
        }
        
    }



}
