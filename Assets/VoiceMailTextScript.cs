using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceMailTextScript : MonoBehaviour
{
    [SerializeField] private GameObject text;

    // Start is called before the first frame update
    public void showText()
    {
        StartCoroutine(ShowAndHide(25.0f));
    }
    IEnumerator ShowAndHide(float delay)
    {
        text.SetActive(true);
        yield return new WaitForSeconds(delay);
        text.SetActive(false);
    }
}
