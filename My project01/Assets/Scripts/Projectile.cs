using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        //발사체에 부딪힌 오브젝트의 태그가 에너미면
        if(collision.CompareTag("Enemy"))
        {//부딪힌 오브젝트 사망처리(적)
            collision.GetComponent<Enemy>().OnDie();
            //내 오브젝트 삭제(발사체)
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
