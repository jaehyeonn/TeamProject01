using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        //������ �ε��� ������Ʈ�� �±װ� �÷��̾� �̸�
        if (collision.CompareTag("Player"))
        {
            //�÷��̾���
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
