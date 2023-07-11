using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private float spawnInterval = 2f;

    private IEnumerator spawnEnemy(float spawnInterval, GameObject enemyPrefab)
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            GameObject enemy = Instantiate(enemyPrefab, new Vector3(Random.Range(-5f, 5f), 1, Random.Range(-5f, 5f)), Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(spawnInterval, enemyPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
