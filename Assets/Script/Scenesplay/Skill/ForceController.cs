using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceController : MonoBehaviour
{
    public GameObject Force;
    public GameObject LoadForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParamiterAll.Count += Time.deltaTime;
        if(ParamiterAll.Count >= 20)
        {
            Force.gameObject.SetActive(false);
            
        }
        if (ParamiterAll.Count >= 60)
        {
            Skill.checkForce = true;
            ParamiterAll.Count = 0;
            Force.gameObject.SetActive(true);
            LoadForce.SetActive(false);
            gameObject.SetActive(false);
        }
            

    }
}
