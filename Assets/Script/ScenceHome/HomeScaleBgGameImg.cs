using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScaleBgGameImg : MonoBehaviour
{
    public GameObject backgroundImge;
    public Camera mainCam;
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
}
