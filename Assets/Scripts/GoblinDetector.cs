using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Goblin"))
        {
            Debug.Log("Goblin detected!");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }
}
