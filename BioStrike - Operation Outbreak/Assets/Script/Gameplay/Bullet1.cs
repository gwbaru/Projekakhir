using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {
            collision.GetComponent<enemy2>().TakeDamage(20);
            Destroy(gameObject);
        }
    }
}