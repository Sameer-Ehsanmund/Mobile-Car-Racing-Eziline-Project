using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreamCar01Script : MonoBehaviour
{
    public GameObject theMarker;

    public GameObject[] markers;

    public int markTracker;
    
    void Update()
    {

        foreach (GameObject marker in markers)
        {

            for (int i = 0; i < markers.Length; i++)
            {

                if (i == markTracker)
                {

                    theMarker.transform.position = markers[i].transform.position;
                }               
            }
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Dreamcar01")
        {

            this.GetComponent<BoxCollider>().enabled = false;

            markTracker += 1;

            if (markTracker == 30)
            {

                markTracker = 0;
            }

            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
