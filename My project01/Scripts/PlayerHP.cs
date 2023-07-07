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

        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        if (currentHP <= 0)
        {
            Debug.Log("Player HP : 0..Die");
        }
    }

    private IEnumerator HitColorAnimation()
    {
        //플레이어의 색상을 빨간색으로
        spriteRenderer.color = Color.red;
        //0.1초 동안 대기
        yield return new WaitForSeconds(0.1f);
        //플레이어의 색상을 원래 색상인 하얀색으로
        //원래 색상이 하얀색이 아닐 경우 원래 색상 변수 선언
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
