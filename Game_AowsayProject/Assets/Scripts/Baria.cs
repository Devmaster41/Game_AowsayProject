using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baria : MonoBehaviour
{
    public GameObject Baria_;
    static  public bool _Baria = true;
    private float n;
    // Start is called before the first frame update
    void Start()
    {
        Baria_.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(_Baria == false)
            n += Time.deltaTime;
        if (n > 10)
            Baria_.gameObject.SetActive(false);
        if (n >= 30)
        {
            n = 0;
            _Baria = true;
        }        
    }

    private void OnMouseDown()
    {
        if (_Baria)
        { 
            Baria_.gameObject.SetActive(true);
            _Baria = false;
        }
            
    }
}
