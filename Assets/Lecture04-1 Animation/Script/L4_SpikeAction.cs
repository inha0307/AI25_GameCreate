using UnityEngine;

public class L4_SpikeAction : MonoBehaviour
{
    public static float speed = 5f;          // ��� Spike�� �����ϴ� �ӵ�
    public static float acceleration = 0.5f; // �ʴ� �ӵ� ������

    void Start()
    {
        Application.targetFrameRate = 180;
    }

    void Update()
    {
        // ��� �ð��� ����ؼ� �ӵ� ���� (��� Spike�� ����)
        speed += acceleration * Time.deltaTime;

        // �ӵ��� ������� �̵�
        float moveX = speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x - moveX, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
