using System.Diagnostics.CodeAnalysis;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject player;

    [SerializeField] float turnSpeed = 0.1f;
    [SerializeField] float turnAngle = 20.0f;

    [SerializeField] float speed = 10.0f;   
    private float horizontalInput;
    private float verticalInput;

    private Vector3 pos;
    [SerializeField] float zRange = 15.0f;
    [SerializeField] float xRange = 16.0f;

    void Start()
    {
        
    }

    void Update()
    {
        //movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * Time.deltaTime * speed * Vector3.right, Space.World);
        transform.Translate(verticalInput * Time.deltaTime * speed * Vector3.forward, Space.World);

        //slight turn
        if (transform.rotation.eulerAngles.y < turnAngle)
        {
            Debug.Log(transform.rotation.eulerAngles.y);
            transform.Rotate(0, horizontalInput * turnSpeed, 0);
        }

        //shoot food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //clamp
        pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -xRange, xRange);
        pos.z = Mathf.Clamp(transform.position.z, ((zRange - 15 ) * -1), zRange);
        transform.position = pos;
    }
}
