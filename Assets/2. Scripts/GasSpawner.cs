using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasSpawner : MonoBehaviour
{
    [SerializeField] private StageData stageData;
    [SerializeField] private GameObject gasPrefabs;
    [SerializeField] private float spawnTime;

    private int number;
    private float positionX;
    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            number = Random.Range(0, 3);
            if (number == 0)
                positionX = -1.4f;
            else if (number == 1)
                positionX = 0f;
            else if (number == 2)
                positionX = 1.4f;
            Instantiate(gasPrefabs, new Vector3(positionX, stageData.LimitMax.y + 1.0f, 0.0f), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
