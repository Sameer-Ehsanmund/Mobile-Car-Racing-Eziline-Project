using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class raceFinish : MonoBehaviour
{
    public GameObject theCar;
    public GameObject finishCamera;
    public GameObject viewModes;
    public GameObject levelMusic;
    public GameObject completeTrigger;

    //public AudioSource levelMusic;

    void OnTriggerEnter()
    {

                this.GetComponent<BoxCollider>().enabled = false;

                theCar.SetActive(false);
                completeTrigger.SetActive(false);

                CarController SP = theCar.GetComponent<CarController>();
                SP.m_Topspeed = 0.0f;

                theCar.GetComponent<CarController>().enabled = false;
                theCar.GetComponent<CarUserControl>().enabled = false;

                theCar.SetActive(true);
                finishCamera.SetActive(true);

                levelMusic.SetActive(false);
                viewModes.SetActive(false);
    }
}
