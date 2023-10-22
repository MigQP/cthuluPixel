using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int lives = 3;

    bool isGameOver;

    public GameObject gameOverPanel;

    private AudioManager audioManager;

    void Awake()
    {
        instance = this;

        audioManager = FindObjectOfType<AudioManager>();
    }


    private void Update()
    {
        if (lives == 0)
        {
            Debug.Log("GAME OVER");
            gameOverPanel.SetActive(true);
            isGameOver = true;
            audioManager.GameOverFade();
        }
    }



    public void SetLives(int amount)
    {
        lives -= amount;
        HeartsManager.instance.DestroyHeart();
    }


    public bool ReadIsGameOver()
    {
        return isGameOver;
    }

    public void SetIsGameOver()
    {
        isGameOver = true;
    }
}
