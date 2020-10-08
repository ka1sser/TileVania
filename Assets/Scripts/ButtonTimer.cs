using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTimer : MonoBehaviour
{
    [SerializeField] GameObject startButton;


    void Start()
    {
        StartCoroutine(ShowButton());
    }

    IEnumerator ShowButton()
    {
        startButton.SetActive(false);

        yield return new WaitForSeconds(5);
        startButton.SetActive(true);
    }
}
