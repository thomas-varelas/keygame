﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearTimer : MonoBehaviour
{

    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timesUpText;

    // Start is called before the first frame update
    void Start()
    {   timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        
    }

    // Update is called once per frame
    void Update()
    {   if (timeLeft>0) {
        timeLeft -= Time.deltaTime;
        timerBar.fillAmount = timeLeft / maxTime;
        } else {
        timesUpText.SetActive(true);
        Time.timeScale=0;
        //CoroutineAction();
        Application.Quit();
        }
    }
    /*
    public IEnumerator CoroutineAction()
    {
    // do some actions here  
    yield return StartCoroutine(WaitForSeconds(5)); // wait for 5 frames
    // do some actions after 5 frames
    }
    */
}
