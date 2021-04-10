using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScence : MonoBehaviour
{
   public void  _NextScence()
    {
        SceneManager.LoadScene("Playgame");
    }
}
