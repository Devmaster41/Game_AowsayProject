using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    static AudioSource Boom;
  
    // Start is called before the first frame update
    void Start()
    {
        Boom = GetComponent<AudioSource>();
    }

    public static void _Boom()
    {
        Boom.GetComponent<AudioSource>().Play();
    }
}
