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
        GameObject enemy = default;  
        while(true)
        {
            
            //적 캐릭터 생성
            enemy = Instantiate(enemyPrefab, new Vector3(Random.Range(-20, 20),0f,Random.Range(50,40)), enemyPrefab.transform.rotation);

            //spawntime만큼 대기
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
