using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset;   
    public float smoothSpeed = 0.125f; 

    void LateUpdate()
    {
        
        Vector3 desiredPosition = target.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Apply the position to the camera
        transform.position = smoothedPosition;

        // camera always facing the target
        transform.LookAt(target);
    }
}

