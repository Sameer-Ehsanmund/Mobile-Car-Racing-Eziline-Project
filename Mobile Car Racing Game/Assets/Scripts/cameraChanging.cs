using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChanging : MonoBehaviour
{
    public GameObject normalCamera;
    public GameObject farCamera;
    public GameObject FPCamera;

    public int cameraMode;

    void Update()
    {

        if (Input.GetButtonDown("ViewMode"))
        {

            if (cameraMode == 2)
            {

                cameraMode = 0;
            }
            else
            {

                cameraMode += 1;
            }

            StartCoroutine(modeChange());
        }
    }

    IEnumerator modeChange()
    {

        yield return new WaitForSeconds(0.01f);

        if (cameraMode == 0)
        {

            normalCamera.SetActive(true);
            FPCamera.SetActive(false);
        }

        if (cameraMode == 1)
        {

            farCamera.SetActive(true);
            normalCamera.SetActive(false);
        }

        if (cameraMode == 2)
        {

            FPCamera.SetActive(true);
            farCamera.SetActive(false);
        }
    }
}
