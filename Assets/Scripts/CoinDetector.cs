using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDetector : MonoBehaviour
{
    int score = 0;
    [SerializeField] GameObject canvas;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score++;
            canvas.GetComponent<UnityEngine.UI.Text>().text = "Coins: " + score;
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject, 0.2f);
        }
    }
}
