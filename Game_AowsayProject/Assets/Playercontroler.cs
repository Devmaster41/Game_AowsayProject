using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    Vector3 target = Vector3.back;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position,target,Speed*Time.deltaTime );
    }
}
