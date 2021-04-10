using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    private  float aphaLevel = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, aphaLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

   
}
