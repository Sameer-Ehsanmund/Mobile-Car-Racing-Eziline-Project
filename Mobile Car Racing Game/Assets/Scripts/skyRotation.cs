using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyRotation : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {

        RenderSettings.skybox.SetFloat("_Rotation", rotationSpeed * Time.time);
    }
}
