using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] int hitsRequired = 1;
    [SerializeField] float scaleMultiplier = 0.5f;

    //public DestroyOutOfBound DestroyOutOfBound;

    private void OnTriggerEnter(Collider other)
    {
        hitsRequired--;
        transform.localScale = new Vector3(transform.localScale.x * scaleMultiplier, transform.localScale.y * scaleMultiplier, transform.localScale.z * scaleMultiplier);
        Destroy(other.gameObject);

        if (hitsRequired == 0)
        {
            Destroy(gameObject);
            //DestroyOutOfBound.score++;
        }
    }
    void Start()
    {
        
    }
    void Update()
    {

    }
}
