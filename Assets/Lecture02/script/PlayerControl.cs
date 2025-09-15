using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float Start_Point = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Start_Point+=0.005f;
        transform.position = new Vector3(Start_Point, transform.position.y, transform.position.z);
    }
}
