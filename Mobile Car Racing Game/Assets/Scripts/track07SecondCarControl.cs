using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class track07SecondCarControl : MonoBehaviour
{
    public GameObject carControl;
    public GameObject Dreamcar01;
    public GameObject Dreamcar02;
    public GameObject Dreamcar03;

    void Start()
    {

        carControl.GetComponent<CarController>().enabled = true;
        carControl.GetComponent<CarUserControl>().enabled = true;
        Dreamcar01.GetComponent<CarAIControl>().enabled = true;
        Dreamcar02.GetComponent<CarAIControl>().enabled = true;
        Dreamcar03.GetComponent<CarAIControl>().enabled = true;
    }
}
