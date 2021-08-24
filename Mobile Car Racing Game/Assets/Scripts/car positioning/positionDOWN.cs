using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class positionDOWN : MonoBehaviour
{
    public GameObject positionDisplay;

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "carPos")
        {

            positionDisplay.GetComponent<TextMeshProUGUI>().text = "2nd Place";
        }
    }
}
