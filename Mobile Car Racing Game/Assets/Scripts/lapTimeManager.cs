using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    public void Update()
    {

        milliSecondCount += Time.deltaTime * 10;

        //rawTime += Time.deltaTime;

        milliSecondDisplay = milliSecondCount.ToString("F0");
        milliSecondBox.GetComponent<TextMeshProUGUI>().text = "" + milliSecondDisplay;

        if (milliSecondCount >= 10)
        {

            milliSecondCount = 0;
            secondCount += 1;
        }

        if (secondCount <= 9)
        {

            secondBox.GetComponent<TextMeshProUGUI>().text = "0" + secondCount + ".";
        }
        else
        {

            secondBox.GetComponent<TextMeshProUGUI>().text = "" + secondCount + ".";
        }

        if (secondCount >= 60)
        {

            secondCount = 0;
            minuteCount += 1;
        }

        if (minuteCount <= 9)
        {

            minuteBox.GetComponent<TextMeshProUGUI>().text = "0" + minuteCount + ":";
        }
        else
        {

            minuteBox.GetComponent<TextMeshProUGUI>().text = "" + secondCount + ":";
        }
    }
}
