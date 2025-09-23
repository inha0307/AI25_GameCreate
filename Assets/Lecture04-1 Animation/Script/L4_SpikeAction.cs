using UnityEngine;

public class L4_SpikeAction : MonoBehaviour
{
    public static float speed = 5f;          // 모든 Spike가 공유하는 속도
    public static float acceleration = 0.5f; // 초당 속도 증가량

    void Start()
    {
        Application.targetFrameRate = 180;
    }

    void Update()
    {
        // 경과 시간에 비례해서 속도 증가 (모든 Spike가 공유)
        speed += acceleration * Time.deltaTime;

        // 속도를 기반으로 이동
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
