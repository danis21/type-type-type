using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseCondition : MonoBehaviour {
    int count = 0;
    public GameObject text;
    public GameObject spawner;
    void OnTriggerEnter2D(Collider2D other)
    {    count++;
        if (count == 3) { Destroy(other.gameObject); GameOver(); }
        else
        {
            Destroy(other.gameObject);

        }
        Debug.Log(count);
    }
    public void GameOver()
    {
        Debug.Log("Game Over!!!");
        text.gameObject.SetActive(true);
        spawner.gameObject.SetActive(false);
    }
}
