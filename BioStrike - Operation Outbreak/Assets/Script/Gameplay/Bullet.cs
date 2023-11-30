using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            collision.GetComponent<enemy>().TakeDamage(20);
            Destroy(gameObject);
        }
        
        if (collision.tag == "Ground")
        {
            
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "CameraBorder")
        {

            Destroy(gameObject);


        }
    }
}