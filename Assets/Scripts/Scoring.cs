using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

    public GameObject player;
    public Text displayedScore;

	// Update is called once per frame
	void Update () {
        displayedScore.text = player.GetComponent<Player>().currentScore.ToString();
	}
}
