using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfPointTrigger : MonoBehaviour
{
    public GameObject completeLapTrigger;
    public GameObject halfLapTrigger;

    void OnTriggerEnter()
    {

        completeLapTrigger.SetActive(true);
        halfLapTrigger.SetActive(false);
    }
}
