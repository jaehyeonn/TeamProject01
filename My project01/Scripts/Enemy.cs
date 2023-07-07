using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;
    [SerializeField]
    private int scorePoint = 100;
    private PlayerController playerController;

    private void Awake()
    {
        //1번만 Find 를 이용해 플레이어컨트롤러의 정보를 저장해두고 사용하는 것이 연산에 효율적이다
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        //적에게 부딪힌 오브젝트의 태그가 플레이어 이면
        if (collision.CompareTag("Player"))
        {
            //적 공격력만큼 플레이어 체력 감소
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            //플레이어사망
            Destroy(gameObject);
            //적 사망시 호출하는 함수
            OnDie();
        }
    }

    public void OnDie()
    {
        //플레이어의 점수를 scorePoint만큼 증가시킨다.
        playerController.Score += scorePoint;
        //적 오브젝트 삭제
        Destroy(gameObject);
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
