using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdManager : MonoBehaviour
{
#if UNITY_IOS
    string gameId = "4744818";
#else
    string gameId = "4744819";
#endif

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId);
        ShowBanner();
        // Advertisement.Show("video");
        // PlayAd();
        ShowBanner2();
    }

    public void ShowBanner(){
        // if (Advertisement.IsReady("banner")){
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show("banner");
        // } else{
        //     StartCoroutine(RepeatShowBanner());
        // }
    }

    // public async void PlayAd(){
    //     Advertisement.Show("video");
    // }
    public void ShowBanner2(){
            Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
            Advertisement.Banner.Show("banner2");
    }

    IEnumerator RepeatShowBanner(){
        yield return new WaitForSeconds(1);
        ShowBanner();
        // ShowBanner2();
    }

}
