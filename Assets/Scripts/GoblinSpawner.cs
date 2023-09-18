using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinSpawner : MonoBehaviour
{

    [SerializeField] GameObject goblinPrefab;
    void Start()
    {
        spawnGoblinsPeriodically();
    }

    void spawnGoblinsPeriodically()
    {

        StartCoroutine(SpawnGoblinsRoutine());

        IEnumerator SpawnGoblinsRoutine()
        {

            while (true)
            {
                yield return new WaitForSeconds(1);
                // Spawn Goblin
                GameObject goblin = Instantiate(goblinPrefab, new Vector3(Random.Range(-5, 5), 6, 0), Quaternion.identity);
                Destroy(goblin, 10);
            }

        }
    }
}
