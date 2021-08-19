using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class countDownScript : MonoBehaviour
{
    public GameObject countDown;

    public AudioSource getReady;
    public AudioSource goAudio;

    public GameObject lapTimer;
    public GameObject carControls;

    public AudioSource levelMusic;

    void Start()
    {

        StartCoroutine(countStart());
    }

    IEnumerator countStart()
    {
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<TextMeshProUGUI>().text = "3";
        getReady.Play();
        countDown.SetActive(true);

        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<TextMeshProUGUI>().text = "2";
        getReady.Play();
        countDown.SetActive(true);

        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<TextMeshProUGUI>().text = "1";
        getReady.Play();
        countDown.SetActive(true);

        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        goAudio.Play();
        levelMusic.Play();

        lapTimer.SetActive(true);
        carControls.SetActive(true);
    }
}
