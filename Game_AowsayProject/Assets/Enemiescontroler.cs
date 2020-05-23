using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemiescontroler : MonoBehaviour
{
    public GameObject Earth;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Earth = GameObject.Find("Earth");
        transform.up = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(Earth != null)
            transform.position = Vector2.MoveTowards(transform.position,Earth.transform.position,Speed*Time.deltaTime);
    }

    private void OnMouseDown()
    {
        ScoreManager.scoreValue++;
        Destroy(gameObject);
    }
}
