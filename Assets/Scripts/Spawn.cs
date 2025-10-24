using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] animalArray;
    private int animalIndex;

    [SerializeField] Vector3 spawnPosition;
    [SerializeField] float randomXRange = 15.0f;
    [SerializeField] float spawnZ = 15;
    void SpawnAnimal() 
    {
        animalIndex = Random.Range(0, animalArray.Length);
        Instantiate(animalArray[animalIndex], new Vector3(Random.Range(-randomXRange, randomXRange), 0, spawnZ), animalArray[animalIndex].transform.rotation);
    }
    void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), 2f, 1f);
    }

    void Update()
    {

    }
}
