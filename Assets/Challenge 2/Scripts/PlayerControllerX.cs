using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    [SerializeField] Vector3 dogSpawnPosition = new Vector3(0, 0, 0);
    [SerializeField] float cooldown = 2.0f;

    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer > cooldown)
            {
                Instantiate(dogPrefab, dogSpawnPosition, dogPrefab.transform.rotation);
                timer = 0;
            }
        }
        timer += Time.deltaTime;
    }
}
