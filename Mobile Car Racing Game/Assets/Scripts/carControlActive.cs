using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class carControlActive : MonoBehaviour
{
    public GameObject carControl;
    public GameObject Dreamcar01;
    
    void Start()
    {

        carControl.GetComponent<CarController>().enabled = true;
        carControl.GetComponent<CarUserControl>().enabled = true;
        Dreamcar01.GetComponent<CarAIControl>().enabled = true;
    }
}
