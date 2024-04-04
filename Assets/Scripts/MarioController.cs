using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MarioController : MonoBehaviour
{

    private int mobCount = 0;

    public int GetMobCount()
    {
        return mobCount;
    }
    public float speed = 10f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    public int coinCount = 0;
    public Text mobText;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            isJumping = false;
        }
        if (collision.gameObject.tag == "mob")
        {
            // Проверяем, падает ли игрок
            if (GetComponent<Rigidbody2D>().velocity.y < 0)
            {
                Destroy(collision.gameObject);
                mobCount++;
                mobText.text = "Убито монстров: " + mobCount;
            }
            else
            {
                // Если игрок не падает, уничтожаем героя
                Destroy(gameObject);
                // Здесь можно добавить код для проигрыша, например:
                // GameManager.instance.GameOver();
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            coinCount++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("mob"))
        {
            mobCount++;
            Destroy(other.gameObject);
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
    }
    
}