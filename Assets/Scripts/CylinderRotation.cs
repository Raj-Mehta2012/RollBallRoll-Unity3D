using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    public float rotationSpeed = 50f;  // Speed of rotation around the Z axis

    void Update()
    {
        // Rotate the object around its Z axis at the specified speed
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
