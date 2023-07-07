using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemyprojectile : MonoBehaviour
{
    public GameObject bulletPrefab = default;
    public float spawnRateMin = 0.5f;
    public float spawnerRateMax = 3f;

    private Transform target = default;
    private float spawnRate = default;
    private float timeAfterSpawn = default;
    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnerRateMax);

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (spawnRate <= timeAfterSpawn)
        {
            timeAfterSpawn = 0;
            GameObject bullet = Instantiate(
                bulletPrefab, transform.position, transform.rotation);



            //spawnRate = Random.Range(spawnRateMin, spawnerRateMax);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        //������ �ε��� ������Ʈ�� �±װ� �÷��̾� �̸�
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            player.Die();
        }
        
    }
}
