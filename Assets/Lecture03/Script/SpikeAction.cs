using UnityEngine;

public class SpikeAction : MonoBehaviour
{
    float Start_XPoint;
    float Start_YPoint;

    void Start()
    {
        // 초기 위치 저장
        Start_XPoint = transform.position.x;
        Start_YPoint = transform.position.y;
    }

    void Update()
    {
        Start_XPoint -= 0.025f;
        transform.position = new Vector3(Start_XPoint, Start_YPoint, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
