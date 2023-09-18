using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoingSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject coinPrefab;
    void Start()
    {
        spawnCoinsPeriodically();
    }

    void spawnCoinsPeriodically()
    {

        StartCoroutine(SpawnCoinsRoutine());

        IEnumerator SpawnCoinsRoutine()
        {

            while (true)
            {
                yield return new WaitForSeconds(4.5f);
                // Spawn Goblin
                GameObject coin = Instantiate(coinPrefab, new Vector3(Random.Range(-5, 5), 6, 0), Quaternion.identity);
                Destroy(coin, 10);
            }

        }
    }
}
