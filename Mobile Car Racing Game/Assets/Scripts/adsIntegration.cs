using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adsIntegration : MonoBehaviour
{

    string gameID = "4302777";

    bool testmode = true;

    string videoAdID = "Interstitial_Android";
    //string rewardedVideoAdID = "Rewarded_Android";
    string bannerAdID = "Banner_Android";

    void Start()
    {

        //Advertisement.AddListener(this);
        Advertisement.Initialize(gameID, testmode);
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_LEFT);
        StartCoroutine(showingBannerAD());
    }

    IEnumerator showingBannerAD()
    {

        while (Advertisement.isInitialized)
        {

            yield return new WaitForSeconds(0.5f);
        }

        Advertisement.Banner.Show(bannerAdID);
    }

    public void displayVideoAd()
    {

        if (Advertisement.IsReady())
        {

            Advertisement.Show(videoAdID);
        }
        else
        {

            Debug.Log("connect to internet");
        }
    }    
}
