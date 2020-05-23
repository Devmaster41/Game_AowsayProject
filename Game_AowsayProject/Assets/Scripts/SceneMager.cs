using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMager : MonoBehaviour
{
    public GameObject StartScene;
    public GameObject Baria;
    public GameObject Earth;
    static public bool StartGame;
    // Start is called before the first frame update
    void Start()
    {
        StartGame = false;
        StartScene.gameObject.SetActive(true);
        Baria.gameObject.SetActive(false);
        Earth.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
            
    }

    private void OnMouseDown()
    {
        StartGame = true;
        StartScene.gameObject.SetActive(false);
        Baria.gameObject.SetActive(true);
        Earth.gameObject.SetActive(true);
    }
}
