using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera mainCamera;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            mainCamera.orthographic = !mainCamera.orthographic;
        }
    }
}
