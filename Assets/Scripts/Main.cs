using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    public Text Counter;

    public float timerS = 0.0f;
    private int Checker = 0;

    void Start()
    {
        Debug.Log("Start!");
        Application.runInBackground = true;
        Debug.Log("Run in Background = true");
        
    }


    void Update()
    {

        if (timerS > 0) // counting
        {
            timerS -= Time.deltaTime; // counting from time to 0
        }
        else
        {
            Debug.Log("Done");
        }

        Count(timerS);
    }


    void Count(float renderTime)
    {
        if(renderTime < 0)
        {
            renderTime = 0;
        }

        float minutes = Mathf.FloorToInt(renderTime / 60);
        float seconds = Mathf.FloorToInt(renderTime % 60);

        Counter.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    public void Mdma()
    {
        timerS = 5400.0f;
        Debug.Log("MDMA timer set : TimerS 5400.0f / 90 minuten");
    }

    public void TwoCB()
    {
        timerS = 5400.0f;
        Debug.Log("2CB timer set : TimerS 5400.0f / 90 minuten");
    }

    public void keta()
    {
        timerS = 1800.0f;
        Debug.Log("KETA timer set : TimerS 1800.0f / 30 minuten");
    }

    public void lsd()    {
        timerS = 10800.0f;
        Debug.Log("LSD timer set : TimerS 10800.0f / 180 minuten");
    }

    public void reseting()
    {
        Checker += 1;
        
        if(Checker > 3)
        {
            timerS = 0.0f;
            Checker = 0;
        }
        else
        {
            Debug.Log("Checker");
        }
    }
}
