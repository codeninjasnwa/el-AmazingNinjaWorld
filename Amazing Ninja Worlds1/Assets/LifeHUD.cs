using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = 3;
    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("heart");
    }
    public void HurtPlayer() {
        
        lives -= 1;
        hearts[lives].SetActive(false);
        if (lives == 0) {
            background.GetComponent<GameManager>().GameOver();
        }
    }

    public void HealPlayer()
    {
        
        if (lives <3) {
            lives += 1;
        hearts[lives].SetActive(true);
        }
    }
}
