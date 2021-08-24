using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuAppearence : MonoBehaviour
{
    public GameObject button;
    public GameObject text;
    public GameObject buttonPanel;

    public void onClickingAnywhere()
    {

        button.SetActive(false);
        text.SetActive(false);
        buttonPanel.SetActive(true);
    }
}
