using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    bool isJumping = false;
    public float JumpPower = 10.0f;

    public GameObject text;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        text.gameObject.SetActive(false);
    }

    void Update()
    {
        // �����̽��� ������ �� ����
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isJumping)
        {
            Debug.Log("Space Action");
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpPower);
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �ٴڿ� ������ ���� ����
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }

        // Enemy�� ������ ���� ���߰� �ؽ�Ʈ ǥ��
        if (collision.gameObject.CompareTag("Enemy"))
        {
            text.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
