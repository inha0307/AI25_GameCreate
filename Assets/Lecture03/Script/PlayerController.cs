using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    bool isJumping = false;
    public float JumpPower = 10.0f;

    public GameObject text;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame && !isJumping)
        {
            Debug.Log("Space Action");
            //rb.linearVelocityY = 10.0f;
            rb.linearVelocity = new Vector2(0.0f, JumpPower);
            isJumping = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            text.gameObject.SetActive(true);
        }
    }
}
