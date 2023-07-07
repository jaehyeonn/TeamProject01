using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private KeyCode KeyCodeAttack = KeyCode.Space;
    private Movement movement;
    private Weapon weapon;

    private void Awake()
    {
        movement = GetComponent<Movement>();
        weapon = GetComponent<Weapon>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //방향키를 눌러 이동 방향 설정
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        movement.MoveTo(new Vector3(x, 0, z));

        //공격 키를 Down/Up으로 공격 시작/종료
        if(Input.GetKeyDown(KeyCodeAttack))
        {
            weapon.StartFiring();
        }
        else if(Input.GetKeyUp(KeyCodeAttack))
        {
            weapon.StopFiring();
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
