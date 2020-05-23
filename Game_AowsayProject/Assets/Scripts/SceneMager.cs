using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMager : MonoBehaviour
{
    public GameObject StartScene;
    static public bool StartGame;
    // Start is called before the first frame update
    void Start()
    {
        StartGame = false;
        StartScene.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      
            
    }

    private void OnMouseDown()
    {
        StartGame = true;
        StartScene.gameObject.SetActive(false);
    }
}
