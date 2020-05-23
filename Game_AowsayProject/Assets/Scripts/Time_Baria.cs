using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Baria : MonoBehaviour
{
    public GameObject Time;
    void Start()
    {
        Time.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Baria._Baria)
            Time.gameObject.SetActive(false);
        else
            Time.gameObject.SetActive(true);
    }
}
