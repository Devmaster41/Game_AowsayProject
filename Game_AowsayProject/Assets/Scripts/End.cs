using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject Baria;
    public GameObject Earth;
    static public bool StartGame;
    public GameObject _End;
    public GameObject Wave;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        Baria.gameObject.SetActive(false);
        Earth.gameObject.SetActive(false);
        Baria.gameObject.SetActive(false);
        Earth.gameObject.SetActive(false);
        Wave.gameObject.SetActive(false);

    }

    public void _Start()
    {
        _End.gameObject.SetActive(false);
        Baria.gameObject.SetActive(true);
        Earth.gameObject.SetActive(true);
        Wave.gameObject.SetActive(true);
        Valuse.End_Start();
    }
}
