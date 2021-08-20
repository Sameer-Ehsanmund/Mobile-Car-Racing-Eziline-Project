using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class lapCompletion : MonoBehaviour
{
    public GameObject completeLapTrigger;
    public GameObject halfLapTrigger;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject millSecondDisplay;

    public GameObject lapTimeBox;

    public GameObject lapCounter;
    public int lapsDone;

    public float rawTime;

    public GameObject raceFinish;

    void Update()
    {

        if (lapsDone == 2)
        {

            raceFinish.SetActive(true);
            //Debug.Log("2");
        }
    }

    void OnTriggerEnter()
    {

        lapsDone += 1;

        rawTime = PlayerPrefs.GetFloat("rawTime");

        if (lapTimeManager.rawTime <= rawTime)
        {

            if (lapTimeManager.secondCount <= 9)
            {

                secondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + lapTimeManager.secondCount + ".";
            }
            else
            {

                secondDisplay.GetComponent<TextMeshProUGUI>().text = "" + lapTimeManager.secondCount + ".";
            }

            if (lapTimeManager.minuteCount <= 9)
            {

                minuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + lapTimeManager.minuteCount + ".";
            }
            else
            {

                minuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + lapTimeManager.minuteCount + ".";
            }

            millSecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + (int)lapTimeManager.milliSecondCount;
        }

        PlayerPrefs.SetInt("MinuteSave", lapTimeManager.minuteCount);
        PlayerPrefs.SetInt("SecondSave", lapTimeManager.secondCount);
        PlayerPrefs.SetFloat("MilliSecondSave", lapTimeManager.milliSecondCount);
        PlayerPrefs.SetFloat("rawTime", lapTimeManager.rawTime);

        lapTimeManager.minuteCount = 0;
        lapTimeManager.secondCount = 0;
        lapTimeManager.milliSecondCount = 0;
        lapTimeManager.rawTime = 0;

        lapCounter.GetComponent<TextMeshProUGUI>().text = "" + lapsDone;
        //Debug.Log(lapsDone);

        halfLapTrigger.SetActive(true);
        completeLapTrigger.SetActive(false);
    }
}
