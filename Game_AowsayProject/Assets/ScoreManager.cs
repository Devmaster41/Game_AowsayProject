using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    static public int scoreValue = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score :" + scoreValue.ToString();
    }
}
