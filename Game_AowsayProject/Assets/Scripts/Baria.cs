using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baria : MonoBehaviour
{
    public GameObject Baria_;
    public GameObject time_ ;
    static  public bool _Baria = true;

    // Start is called before the first frame update
    void Start()
    {
        Baria_.gameObject.SetActive(false);
        time_.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(_Baria == false)
            Valuse.Count += Time.deltaTime;
        if (Valuse.Count > 10)
            Baria_.gameObject.SetActive(false);
        if (Valuse.Count >= 30)
        {
            Valuse.Count = 0;
            _Baria = true;
            time_.gameObject.SetActive(false);
        }        
    }

    private void OnMouseDown()
    {
        if (_Baria)
        { 
            Baria_.gameObject.SetActive(true);
            time_.gameObject.SetActive(true);
            _Baria = false;
        }
            
    }
}
