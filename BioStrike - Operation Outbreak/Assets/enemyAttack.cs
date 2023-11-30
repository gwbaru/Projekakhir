using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("player detected");
            //attackfunction
            collision.GetComponent<Stealth>().GetDetected();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("player detected");
            //attackfunction
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
