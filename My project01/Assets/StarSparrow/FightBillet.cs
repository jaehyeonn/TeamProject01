using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBillet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        //적에게 부딪힌 오브젝트의 태그가 플레이어 이면
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            player.Die();
        }

    }
}
