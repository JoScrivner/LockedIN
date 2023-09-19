using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCheck : MonoBehaviour
{
    public int dragonNo;
    public int realGemNo;

    public bool isDone = false;

    public GameObject[] realGems;


    //[SerializeField] private GameObject winnerscreen;


    // Start is called before the first frame update
    void Start()
    {
        dragonNo = 0;
        realGemNo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDone == false && (realGemNo == 3) && (dragonNo == 1))
        {
            AudioManagerScript.PlaySound("success");
            //winnerscreen.SetActive(true);

            isDone = true;


            realGems = GameObject.FindGameObjectsWithTag("realGem");

            foreach (GameObject gem in realGems)
            {
                gem.SetActive(false);
            }


        }
    }
}
