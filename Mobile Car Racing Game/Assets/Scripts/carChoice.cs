using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carChoice : MonoBehaviour
{
    public GameObject carColor1;
    public GameObject carColor2;
    public GameObject carColor3;
    public GameObject carColor4;
    public GameObject carColor5;
    public GameObject carColor6;
    public GameObject carColor7;
    public GameObject carColor8;

    public int carImport;

    void Start()
    {

        carImport = globalCar.carType;

        if (carImport == 1)
        {

            carColor1.SetActive(true);
        }

        if (carImport == 2)
        {

            carColor2.SetActive(true);
        }

        if (carImport == 3)
        {

            carColor3.SetActive(true);
        }

        if (carImport == 4)
        {

            carColor4.SetActive(true);
        }

        if (carImport == 5)
        {

            carColor5.SetActive(true);
        }

        if (carImport == 6)
        {

            carColor6.SetActive(true);
        }

        if (carImport == 7)
        {

            carColor7.SetActive(true);
        }

        if (carImport == 8)
        {

            carColor8.SetActive(true);
        }
    }
}
