using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    private float bulletSpawnPointX;
    public float playerMoveSpeed = 0f;
    private float Move;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float jump;
    public bool isJumping;
    public Animator animator;
    public SpriteRenderer sprite;
    private float horizontalInput;


    [SerializeField]
    private int totalJump;

    public int airCount;

    private Rigidbody2D rb;

    [SerializeField]
    private float JumpPower;

    // Start is called before the first frame update
    void Start()
    {
        bulletSpawnPointX = bulletSpawnPoint.localPosition.x;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        animator.SetBool("isMoving", horizontalInput != 0);

                //Flip animator sprite
        if (Move > 0.1f)
        {
            sprite.flipX = false;
            bulletSpawnPoint.localPosition = new Vector2(bulletSpawnPointX, bulletSpawnPoint.localPosition.y);
            animator.SetBool("run player", true);
        }

        else if (Move< -0.1f)
        {
            sprite.flipX = true;
            bulletSpawnPoint.localPosition = new Vector2(bulletSpawnPointX*-1f, bulletSpawnPoint.localPosition.y);
            animator.SetBool("run player", true);
        }

        else
        {
            animator.SetBool("run player", false);
        }
    
        //Jump Button
       if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && airCount < totalJump)
        {
            Vector2 direction = new Vector2(0, 1);
            rb.velocity = direction * JumpPower;
            airCount += 1;
            Debug.Log("Up");
            AudioManagerLevel1.instance.PlaySFX("Jump");
        }
        //Move Left Button
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * playerMoveSpeed * Time.deltaTime;
            Debug.Log("Left");
            
        }
        //Down Button
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * playerMoveSpeed * Time.deltaTime;
            Debug.Log("Down");

        }
        //Move Right Button
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * playerMoveSpeed * Time.deltaTime;
            Debug.Log("Right");
            
        }
        //Shooting Button
        if(Input.GetKeyDown(KeyCode.Space))
        {

            //transform.Translate(Time.deltaTime*bulletSpeed*transform.right);
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            //Bullet _bullet = bullet.GetComponent<Bullet>();
            //_bullet.speed = bulletSpeed;
            if (sprite.flipX)
            {
                bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * -bulletSpeed;
            }

            if (!sprite.flipX)
            {
                bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;
            }
            AudioManagerLevel1.instance.PlaySFX("Gun");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
        {
            
        }

    private void OnCollisionExit2D(Collision2D other)
        {
            
        }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            airCount = 0;
            isJumping = false;
            animator.SetBool("isJumping", false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            animator.SetBool("isJumping", true);
        }
    }
}
