using JetBrains.Annotations;
using UnityEngine;

public class SpikeAction : MonoBehaviour
{
    float Start_XPoint;
    public SpikeSpawner SpikeSpawner;

    void Start()
    {
        // 초기 위치 저장
        Start_XPoint = transform.position.x;
    }

    void Update()
    {
        Start_XPoint -= 0.025f;
        transform.position = new Vector3(Start_XPoint, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
            SpikeSpawner.destroy_a = true;
            Debug.Log(SpikeSpawner.destroy_a);
        }
    }
}
