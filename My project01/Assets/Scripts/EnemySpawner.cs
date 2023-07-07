using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private float spawnTime;

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }
    
    private IEnumerator SpawnEnemy()
    {
        while(true)
        {
            Instantiate(enemyPrefab, new Vector3(), Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
