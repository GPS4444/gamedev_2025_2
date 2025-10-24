using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Time.deltaTime * speed * Vector3.forward);  
    }
}
