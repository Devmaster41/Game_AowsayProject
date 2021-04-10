using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject Gate;
    float a;
    // Start is called before the first frame update
    void Start()
    {
        Gate = GameObject.Find("Gate");
        gameObject.transform.position = new Vector2(Gate.transform.position.x,Gate.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
