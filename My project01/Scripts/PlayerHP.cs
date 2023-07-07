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

        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        if (currentHP <= 0)
        {
            Debug.Log("Player HP : 0..Die");
        }
    }

    private IEnumerator HitColorAnimation()
    {
        //�÷��̾��� ������ ����������
        spriteRenderer.color = Color.red;
        //0.1�� ���� ���
        yield return new WaitForSeconds(0.1f);
        //�÷��̾��� ������ ���� ������ �Ͼ������
        //���� ������ �Ͼ���� �ƴ� ��� ���� ���� ���� ����
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
