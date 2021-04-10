using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public GameObject Force;
   public GameObject LoadForce;
    public GameObject LoadTime;
    public static float Speed = 0.45f;
    public static bool checkForce = true;
    public static bool checkTime = true;

    // Start is called before the first frame update
    void Start()
    {
        ParamiterAll.Count = 0;
        checkForce = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenForce()
    {
        if (checkForce)
        {
            Force.gameObject.SetActive(true);
            LoadForce.gameObject.SetActive(true);
            checkForce = false;
        }
            
    }

    public void Time()
    {
        if (checkTime)
        {
            Speed = 0.1f;
            LoadTime.gameObject.SetActive(true);
        }

       
    }
}
