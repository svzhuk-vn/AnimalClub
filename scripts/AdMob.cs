using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMob : MonoBehaviour
{


    private const string banner = "ca-app-pub-5191344219725963/6733699977";
    // Start is called before the first frame update
    void Start()
    {
        
        BannerView bannerV = new BannerView(banner, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        //AdRequest request = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).AddTestDevice(SystemInfo.deviceUniqueIdentifier.ToUpper()).Build();
        bannerV.LoadAd(request); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
