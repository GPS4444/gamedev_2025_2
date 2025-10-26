using System;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;


    [Header("Movement")]
    [SerializeField] float speed = 10.0f;   
    [SerializeField] float rotationSpeed = 1.0f;
    [SerializeField] float maxAngle = 20.0f;

    [Header("Clamp")]
    [SerializeField] float zRange = 15.0f;
    [SerializeField] float xRange = 16.0f;

    void Start()
    {
        
    }

    void Update()
    {
        //movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * Time.deltaTime * speed * Vector3.right, Space.World);
        transform.Translate(verticalInput * Time.deltaTime * speed * Vector3.forward, Space.World);

        //slight turn 
        if (horizontalInput != 0)
        {
            float angle = Mathf.LerpAngle(transform.eulerAngles.y, Mathf.Clamp(Mathf.Atan(horizontalInput / verticalInput) * Mathf.Rad2Deg, -maxAngle, maxAngle), Time.deltaTime * rotationSpeed);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle, transform.eulerAngles.z);
        }
        
        //shoot food
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //clamp
        Vector3 pos; 
        pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -xRange, xRange);
        pos.z = Mathf.Clamp(transform.position.z, (zRange - 15 ) * -1, zRange);
        transform.position = pos;
    }
}
