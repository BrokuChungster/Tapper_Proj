using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public GameObject attacker;
    public GameObject[] badSprite;
    public decimal health = 10;
    public decimal attack = 2;

    public float xMax = 7.5f;
    public float xMin = 1f;

	// Update is called once per frame
	void Update () {
        playerClick();
        if(health <= 0)
        {
            Destroy(this.gameObject);
            GameObject enimeies = Instantiate(badSprite[Random.Range(0, badSprite.Length-1)], new Vector3(Random.Range(xMin, xMax), -4.3f, 3f), this.transform.rotation);
            Enemy script = enimeies.GetComponent<Enemy>();
            script.attacker = attacker;
            script.badSprite = badSprite;
            script.health = 10m;
            script.attack = attack * 1.05m;
        }
    }

    public void playerClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("health decreases");
            health -= attacker.GetComponent<Player>().attack;
           // return true;
        }
       // return false;
    }
}
