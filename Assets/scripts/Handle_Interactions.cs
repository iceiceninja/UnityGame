using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Handle_Interactions : MonoBehaviour

{
    bool canSpeak = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpeak)
        {
            if(Input.GetKeyDown(KeyCode.F)) 
            {
                Debug.Log("We are talking now");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            if(collision.gameObject.name == "oldman")
            {
                Debug.Log("Hello young child");
                canSpeak = true;
            }
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.name == "oldman")
            {
                Debug.Log("Goodbye young child");
                canSpeak = false;
            }

        }
    }

}
