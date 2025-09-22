using UnityEngine;
using System.Collections;


public class SpikeSpawner : MonoBehaviour
{
    public GameObject spikePrefab;           // ���� ������
    float spawnInterval = 4.0f;              // ���� ���� (��)
    public float spikeSpacing = 1.0f;        // ���� ���� �� ���� ����

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // �� ���ϸ��� ���� ���� ���� (1~3)
            int spikeCount = Random.Range(1, 4);
            Debug.Log("�̹� ���� ���� ��: " + spikeCount);

            // spikeCount ��ŭ ����
            for (int i = 0; i < spikeCount; i++)
            {
                Vector3 spawnPos = transform.position + new Vector3(i * spikeSpacing, 0f, 0f);
                Instantiate(spikePrefab, spawnPos, Quaternion.identity);
            }

            // ���� ���� ������ �� ���
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}