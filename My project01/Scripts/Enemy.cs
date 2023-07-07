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
        //1���� Find �� �̿��� �÷��̾���Ʈ�ѷ��� ������ �����صΰ� ����ϴ� ���� ���꿡 ȿ�����̴�
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        //������ �ε��� ������Ʈ�� �±װ� �÷��̾� �̸�
        if (collision.CompareTag("Player"))
        {
            //�� ���ݷ¸�ŭ �÷��̾� ü�� ����
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            //�÷��̾���
            Destroy(gameObject);
            //�� ����� ȣ���ϴ� �Լ�
            OnDie();
        }
    }

    public void OnDie()
    {
        //�÷��̾��� ������ scorePoint��ŭ ������Ų��.
        playerController.Score += scorePoint;
        //�� ������Ʈ ����
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
