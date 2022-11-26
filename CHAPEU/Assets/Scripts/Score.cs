using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static private int score=0;
    public Text txtScore;
    public GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            score++;
            UpdateScore();
        }
        if (collision.gameObject.CompareTag("Relogio"))
        {
            gc.MudaTempo(20.0f);
        }
        if (collision.gameObject.CompareTag("Coracao"))
        {
            gc.AlteraVidas(1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bomba"))
        {
            gc.AlteraVidas(-1);
        }
    }

    void UpdateScore()
    {
        txtScore.text = "Score:\n" + score;
    }
    public void ScoreAZero()
    {
        score = 0;
        UpdateScore();
    }
}
