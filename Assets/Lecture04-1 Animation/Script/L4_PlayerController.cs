using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class L4_PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    bool isJumping = false;
    public float JumpPower = 10.0f;
    Animator animator;

    public GameObject text;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text.gameObject.SetActive(false);
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            text.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isJumping)
        {
            Debug.Log("Space Action");
            animator.Play("Playerani", -1, 0f);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpPower);
            isJumping = true;
        }
    }
}
