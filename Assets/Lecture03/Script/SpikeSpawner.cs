using UnityEngine;

public class SpikeSpawner : MonoBehaviour
{
    public GameObject SpikePrefab;
    public bool destroy_a = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(destroy_a)
        {
            GameObject spike = Instantiate(SpikePrefab);
            spike.transform.position = transform.position;
            destroy_a = false;
        }
    }
}
