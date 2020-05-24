using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    Vector3 target = Vector3.back;
    public GameObject End;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, target, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Metao") 
        {
            this.gameObject.SetActive(false);
            End.gameObject.SetActive(true);
            Valuse._Metao = true;
        }
    }
}
