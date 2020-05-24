using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveResponse : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] pointer;

    float count = 0f;
    public float waveTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           GameObject randomPoint = pointer[Random.Range(0, pointer.Length)];
           count += Time.deltaTime;
           if (count > waveTime)
           {
               Instantiate(enemy, randomPoint.transform.position, Quaternion.identity);
               count = 0f;
           }
    }
}


