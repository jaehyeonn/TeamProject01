using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        //적에게 부딪힌 오브젝트의 태그가 플레이어 이면
        if (collision.CompareTag("Player"))
        {
            //플레이어사망
            Destroy(gameObject);
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
