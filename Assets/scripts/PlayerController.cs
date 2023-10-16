using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public IAttack attack;

    // Start is called before the first frame update
    void Start()
    {
        attack = gameObject.AddComponent<SwordAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        //Can make attack generic and have user select weapon using weapon wheel. Or just have diff weapons diff keys
        if(Input.GetKeyDown(KeyCode.E))
        {
            attack.Attack(gameObject.transform.position, new Vector2(5.0f,2.0f),0, LayerMask.GetMask("Enemy"));
            Debug.Log("Sword attack");
        }   
    }
}
