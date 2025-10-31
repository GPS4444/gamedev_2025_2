using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    [SerializeField] float zTopBound = 25.0f;
    [SerializeField] float zBottomBound = -5.0f;

    //public int score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > zTopBound)
        {
            Destroy(gameObject);
        } else if(transform.position.z < zBottomBound)
        {
            print("Game Over");
            Destroy(gameObject);
            //print(score);
        }
    }
}
