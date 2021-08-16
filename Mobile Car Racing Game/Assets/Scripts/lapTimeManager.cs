using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lapTimeManager : MonoBehaviour
{
    public static int minuteCount;
    public static int secondCount;

    public static float milliSecondCount;

    public static string milliSecondDisplay;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliSecondBox;

    //public static float rawTime;

    void Update()
    {

        milliSecondCount += Time.deltaTime * 10;

        //rawTime += Time.deltaTime;

        milliSecondDisplay = milliSecondCount.ToString("F1");
        milliSecondBox.GetComponent<Text>().text = "" + milliSecondDisplay;

        if (milliSecondCount >= 10)
        {

            milliSecondCount = 0;
            secondCount += 1;
        }

        if (secondCount <= 9)
        {

            secondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        }
        else
        {

            secondBox.GetComponent<Text>().text = "" + secondCount + ".";
        }

        if (secondCount >= 60)
        {

            secondCount = 0;
            minuteCount += 1;
        }

        if (minuteCount <= 9)
        {

            minuteBox.GetComponent<Text>().text = "0" + minuteCount + ":";
        }
        else
        {

            minuteBox.GetComponent<Text>().text = "" + secondCount + ":";
        }
    }
}
