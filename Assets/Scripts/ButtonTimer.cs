using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTimer : MonoBehaviour
{
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject quitButton;


    void Start()
    {
        StartCoroutine(ShowButton());
    }

    IEnumerator ShowButton()
    {
        startButton.SetActive(false);
        quitButton.SetActive(false);
        yield return new WaitForSeconds(7);
        startButton.SetActive(true);
        quitButton.SetActive(true);
    }
}
