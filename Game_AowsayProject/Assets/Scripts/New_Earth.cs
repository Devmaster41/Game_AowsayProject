using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Earth : MonoBehaviour
{
    public GameObject enemy;
    public GameObject pointer;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, pointer.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
