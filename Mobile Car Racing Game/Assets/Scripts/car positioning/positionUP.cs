using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class positionUP : MonoBehaviour
{
    public GameObject positionDisplay;

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "carPos")
        {

            positionDisplay.GetComponent<TextMeshProUGUI>().text = "1st Place";
        }
    }
}
