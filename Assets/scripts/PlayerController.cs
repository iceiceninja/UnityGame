using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public IAttack rangedAttack;
    public IAttack meleeAttack;

    // Start is called before the first frame update
    void Start()
    {
        rangedAttack = gameObject.GetComponent<ShurikenAttack>();
        meleeAttack = gameObject.GetComponent<SwordAttack>();    
        //meleeAttack = gameObject.AddComponent<ShurikenAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        //Can make attack generic and have user select weapon using weapon wheel. Or just have diff weapons diff keys
        if(Input.GetKeyDown(KeyCode.E))
        {
            meleeAttack.Attack(gameObject.transform.position, new Vector2(5.0f,2.0f),0, LayerMask.GetMask("Enemy"));
            Debug.Log("Sword attack");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rangedAttack.Attack(gameObject.transform.position, new Vector2(5.0f, 2.0f), 0, LayerMask.GetMask("Enemy"));
            Debug.Log("Shurriken attack");
        }
    }
}
