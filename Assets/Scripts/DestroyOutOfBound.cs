using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    [SerializeField] float zTopBound = 25.0f;
    [SerializeField] float zBottomBound = -5.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > zTopBound || transform.position.z < zBottomBound)
        {
            Destroy(gameObject);
        }
    }
}
