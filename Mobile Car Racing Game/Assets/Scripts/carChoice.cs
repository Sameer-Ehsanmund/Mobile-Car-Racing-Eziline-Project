using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carChoice : MonoBehaviour
{
    public GameObject redBody;
    public GameObject blueBody;

    public int carImport;

    void Start()
    {

        carImport = globalCar.carType;

        if (carImport == 1)
        {

            redBody.SetActive(true);
        }

        if (carImport == 2)
        {

            blueBody.SetActive(true);
        }
    }
}
