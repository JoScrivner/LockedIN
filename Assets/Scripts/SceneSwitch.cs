using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        //SceneManager.LoadScene(1);

    }

    public void SwitchScene()
    {
        //StartCoroutine(ExecuteAfterTime(1));
        //StartCoroutine(ExecuteAfterTime(0));
        SceneManager.LoadScene(1);
    }
}
