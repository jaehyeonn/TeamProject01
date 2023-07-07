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
        //����Ű�� ���� �̵� ���� ����
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        movement.MoveTo(new Vector3(x, 0, z));

        //���� Ű�� Down/Up���� ���� ����/����
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
