using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 10; //최대 체력
    private float currentHP; //현재 체력
    private SpriteRenderer spriteRenderer;

    public float MaxHP => maxHP; //maxHP 변수에 접근할 수 있는 프로퍼티 (겟만 가능)
    public float CurrentHP => currentHP;    //currentHP 변수에 접근할 수 있는 프로퍼티 (겟만 가능)


    private void Awake()
    {
        currentHP = maxHP; //현재 체력을 최대 체력과 같게 설정
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        //현재 체력을 damage만큼 감소
        currentHP -= damage;

        //체력이 0이하이면 플레이어 사망
        if (currentHP <= 0)
        {
            PlayerController player = GetComponent<PlayerController>();
            player.Die();
            Debug.Log("Player HP : 0..Die");
        }
    }

   

    //체력이 0이하 = 플레이어 캐릭터 사망
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
