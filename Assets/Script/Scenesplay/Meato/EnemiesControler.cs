using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesControler : MonoBehaviour
{
    public GameObject Earth;
    public GameObject Gate;
 

    /* private void Awake()
     {
         Gate = GameObject.Find("Gate");
         gameObject.transform.position = new Vector2(Gate.transform.position.x-0.02f, Gate.transform.position.y);
     }
    */

    // Start is called before the first frame update
    void Start()
    {
        


        Earth = GameObject.Find("Earth");
        //transform.position = Vector2.MoveTowards(transform.position,Earth.transform.position,Speed*Time.deltaTime);
        transform.up = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Earth != null)
            transform.position = Vector2.MoveTowards(transform.position, Earth.transform.position, Skill.Speed * Time.deltaTime);

    }
    private void OnMouseDown()
    {
        
        Destroy(gameObject);
        Sound._Boom();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        for(byte i = 1; i <= 10; i++)
        {
            if (collision.gameObject.name == "Force" + i + "_1")
            {
                Sound._Boom();
                Destroy(gameObject);
            }
                
        }   
    }

  
}
