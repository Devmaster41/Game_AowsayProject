using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBgGameImg : MonoBehaviour
{
    public GameObject backgroundImge;
    public Camera mainCam;
    public GameObject[] Force;
    public GameObject Earth;
    public GameObject Gate;
    public GameObject MetaoEarth;
    private float srcHeight;
    private float srcWidth;
    private float DEVICE_SCREEN_ASPECT;


    // Start is called before the first frame update
    void Start()
    {
        
        srcHeight = Screen.height;
        srcWidth = Screen.width;
        DEVICE_SCREEN_ASPECT = srcWidth / srcHeight;
        mainCam.aspect = DEVICE_SCREEN_ASPECT;
        scaleBackgroundImgeFitScreenSize();
        REarth();
        ForceALL();
        RGate();
        RMetaoEarth();

    }
  

    private void scaleBackgroundImgeFitScreenSize()
    {
        float camHeight = 100.0f * mainCam.orthographicSize * 2.0f;
        float camWidth = camHeight * DEVICE_SCREEN_ASPECT;


        SpriteRenderer backgroundImageRS = backgroundImge.GetComponent<SpriteRenderer>();
        float bgImgH = backgroundImageRS.sprite.rect.height;
        float bgImgW = backgroundImageRS.sprite.rect.width;


        float bgImg_scale_ratio_Height = camHeight / bgImgH;
        float bgImg_scale_ratio_Width = camWidth / bgImgW;


        backgroundImge.transform.localScale = new Vector3(bgImg_scale_ratio_Width, bgImg_scale_ratio_Height, 1);


    }

    private void ForceALL()
    {
        float camHeight = 60 + mainCam.orthographicSize + 2.0f;
        float camWidth = camHeight + DEVICE_SCREEN_ASPECT;

        for (byte i = 0; i < Force.Length; i++)
        {
            SpriteRenderer _ForceRS = Force[i].GetComponent<SpriteRenderer>();
            float ForceH = _ForceRS.sprite.rect.height;
            float ForceW = _ForceRS.sprite.rect.width;
            float Force_scale_ratio_Height = camHeight / ForceH;
            float Force_scale_ratio_Whidth = camWidth / ForceW;

            Force[i].transform.localScale = new Vector3(Force_scale_ratio_Whidth, Force_scale_ratio_Height, 1);
        }
    }

    private void REarth()
    {
        float camHeight = 60 + mainCam.orthographicSize + 2.0f;
        float camWidth = camHeight + DEVICE_SCREEN_ASPECT;

        SpriteRenderer _EarthRS = Earth.GetComponent<SpriteRenderer>();
        float EarthH = _EarthRS.sprite.rect.height;
        float EarthW = _EarthRS.sprite.rect.width;

        float Earth_scale_ratio_Height = camHeight / EarthH;
        float Earth_scale_ratio_Whidth = camWidth / EarthW;

        Earth.transform.localScale = new Vector3(Earth_scale_ratio_Whidth, Earth_scale_ratio_Height, 1);
        
    }

    private void RGate()
    {
        float camHeight = 65 + mainCam.orthographicSize + 2.0f;
        float camWidth = camHeight + DEVICE_SCREEN_ASPECT;

        SpriteRenderer GateRS = Gate.GetComponent<SpriteRenderer>();
        float GateH = GateRS.sprite.rect.height;
        float GateW = GateRS.sprite.rect.width;

        float Gate_scale_ratio_Height = camHeight / GateH;
        float Gate_scale_ratio_Width = camWidth / GateW;

        Gate.transform.localScale = new Vector3(Gate_scale_ratio_Width, Gate_scale_ratio_Height, 1);
        Gate.transform.position = new Vector2((srcWidth*0)-1.5f, srcHeight*0);

    }

    private void RMetaoEarth()
    {
        float camHeight = 75 + mainCam.orthographicSize + 20.0f;
        float camWidth = camHeight + DEVICE_SCREEN_ASPECT;

        SpriteRenderer MetaoEarthRS = MetaoEarth.GetComponent<SpriteRenderer>();
        float MetaoEarthH = MetaoEarthRS.sprite.rect.height;
        float MetaoEarthW = MetaoEarthRS.sprite.rect.width;

        float MetaoEarth_scale_ratio_Height = camHeight / MetaoEarthH;
        float MetaoEarth_scale_ratio_Width = camWidth / MetaoEarthW;

        MetaoEarth.transform.localScale = new Vector3(MetaoEarth_scale_ratio_Width, MetaoEarth_scale_ratio_Height);
        
    }
}

