using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player_test;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player_test.position.z + 981).ToString("0") ;
    }
}
