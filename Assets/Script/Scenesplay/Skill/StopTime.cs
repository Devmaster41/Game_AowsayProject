using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour
{
   
    private float Count;
    void Start()
    {
        
    }


    void Update()
    {
        Count += Time.deltaTime;
        if (Count >= 5)
            Skill.Speed = 0.45f;
        if(Count >= 25)
        {
            Count = 0;
            Skill.checkTime = true;
            gameObject.SetActive(false);
        }
    }
}
