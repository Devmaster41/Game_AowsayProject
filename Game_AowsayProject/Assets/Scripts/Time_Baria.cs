using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Baria : MonoBehaviour
{
    public GameObject Time;
    void Start()
    {
       
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Baria._Baria==true)
            Time.gameObject.SetActive(false);
        else
            Time.gameObject.SetActive(true);
    }
}
