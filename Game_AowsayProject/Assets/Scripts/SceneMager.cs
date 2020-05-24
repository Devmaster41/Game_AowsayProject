using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMager : MonoBehaviour
{
    public GameObject StartScene;
    public GameObject Baria;
    public GameObject Earth;
    public GameObject Wave;
    public GameObject End;
    // Start is called before the first frame update
    void Start()
    {
        Wave.gameObject.SetActive(false);
        StartScene.gameObject.SetActive(true);
        Baria.gameObject.SetActive(false);
        Earth.gameObject.SetActive(false);
        End.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
            
    }

    private void OnMouseDown()
    {
        Wave.gameObject.SetActive(true);
        StartScene.gameObject.SetActive(false);
        Baria.gameObject.SetActive(true);
        Earth.gameObject.SetActive(true);
    }
}
