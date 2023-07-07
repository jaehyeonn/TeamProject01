using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        //�߻�ü�� �ε��� ������Ʈ�� �±װ� ���ʹ̸�
        if(collision.CompareTag("Enemy"))
        {//�ε��� ������Ʈ ���ó��(��)
            collision.GetComponent<Enemy>().OnDie();
            //�� ������Ʈ ����(�߻�ü)
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
