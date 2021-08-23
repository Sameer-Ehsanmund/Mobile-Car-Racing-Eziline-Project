using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalCar : MonoBehaviour
{
    public static int carType;

    public GameObject trackWindow;

    public void redCar()
    {

        carType = 1;
        trackWindow.SetActive(true);
    }

    public void blueCar()
    {

        carType = 2;
        trackWindow.SetActive(true);
    }
}
