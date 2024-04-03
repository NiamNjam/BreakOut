using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int score;
    public GameObject ball;

    public TMP_Text livesText;
    public TMP_Text scoreText;

    public GameObject winScreen;
    public GameObject loseScreen;

    public AudioClip sound;
    public AudioSource source;

    void Update()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;

        var count = FindObjectsOfType<Brick>().Length;
        if (count <= 0)
        {

            winScreen.SetActive(true);
            source.clip = sound;
            source.Play();
            enabled = false;
        }

        if (lives <= 0)
        {
            loseScreen.SetActive(true);
            Destroy(ball);
            enabled = false;
        }
    }
}
