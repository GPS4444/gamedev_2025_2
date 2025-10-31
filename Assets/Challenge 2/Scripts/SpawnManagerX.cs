using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    [Header("Spawn Position")]
    [SerializeField] float spawnLimitXLeft = -22;
    [SerializeField] float spawnLimitXRight = 7;
    [SerializeField] float spawnPosY = 30;

    [Header("Time")]
    [SerializeField] float startDelay = 1.0f;
    [SerializeField] float spawnIntervalStart = 3.0f;
    [SerializeField] float spawnIntervalEnd = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomBall), startDelay, Random.Range(spawnIntervalStart, spawnIntervalEnd));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
