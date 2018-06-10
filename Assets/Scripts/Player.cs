using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player: MonoBehaviour
{
    public int currentScore = 0 ;
    public Text scoreText;
    public int health = 10;
    public int attack = 2;

    // Update is called once per frame
    void Update ()
    {
        currentScore += playerClick() ? 1 : 0;

    }

    public bool playerClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("pressed button");
            scoreText.text = currentScore.ToString();
            return true;
        }
        return false;
    }

   
}
