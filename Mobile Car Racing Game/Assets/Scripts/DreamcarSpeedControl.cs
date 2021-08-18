using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class DreamcarSpeedControl : MonoBehaviour
{

    public GameObject speedController;

    bool speedC;

    public void Update()
    {
        if (speedC == true)
        {

            CarController SP = speedController.GetComponent<CarController>();
            SP.m_Topspeed = 70f;
            //Debug.Log(SP.m_Topspeed);
        }
        else
        {

            CarController SP = speedController.GetComponent<CarController>();
            SP.m_Topspeed = 140f;
            //Debug.Log(SP.m_Topspeed);
        }
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "speedControl")
        {

            speedC = true;
            Update();
        }
        else
        {

            speedC = false;
            Update();
        }
    }
}
