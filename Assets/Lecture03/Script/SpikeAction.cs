using UnityEngine;

public class SpikeAction : MonoBehaviour
{
    float speed = 5;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        float moveVectoX = Time.deltaTime * speed;
        transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("tkrwprl"))
        {
            Destroy(gameObject);
            Debug.Log("Spike : ¼Ò¸ê");
        }
    }
}
