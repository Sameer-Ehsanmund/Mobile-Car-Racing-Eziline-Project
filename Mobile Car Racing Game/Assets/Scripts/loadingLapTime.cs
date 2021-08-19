using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class loadingLapTime : MonoBehaviour
{
    public int minCount;
    public int secCount;
    public float milliSecCount;

    public GameObject minDisplay;
    public GameObject secDisplay;
    public GameObject milliSecDisplay;

    void Start()
    {

        minCount = PlayerPrefs.GetInt("MinuteSave");
        secCount = PlayerPrefs.GetInt("SecondSave");
        milliSecCount = PlayerPrefs.GetFloat("MilliSecondSave");

        minDisplay.GetComponent<TextMeshProUGUI>().text = "" + minCount + ":";
        secDisplay.GetComponent<TextMeshProUGUI>().text = "" + secCount + ".";
        milliSecDisplay.GetComponent<TextMeshProUGUI>().text = "" + (int)milliSecCount;
    }
}
