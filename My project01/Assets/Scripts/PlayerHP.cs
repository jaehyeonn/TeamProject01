using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 10; //�ִ� ü��
    private float currentHP; //���� ü��
    private SpriteRenderer spriteRenderer;

    public float MaxHP => maxHP; //maxHP ������ ������ �� �ִ� ������Ƽ (�ٸ� ����)
    public float CurrentHP => currentHP;    //currentHP ������ ������ �� �ִ� ������Ƽ (�ٸ� ����)


    private void Awake()
    {
        currentHP = maxHP; //���� ü���� �ִ� ü�°� ���� ����
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        //���� ü���� damage��ŭ ����
        currentHP -= damage;

        //ü���� 0�����̸� �÷��̾� ���
        if (currentHP <= 0)
        {
            PlayerController player = GetComponent<PlayerController>();
            player.Die();
            Debug.Log("Player HP : 0..Die");
        }
    }

   

    //ü���� 0���� = �÷��̾� ĳ���� ���
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
