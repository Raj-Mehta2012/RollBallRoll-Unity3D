using UnityEngine;

public class AttachToParent : MonoBehaviour
{
    public GameObject topObject;  // The object that should stay on top
    public GameObject bottomObject;  // The object that moves

    void Start()
    {
        if (topObject != null && bottomObject != null)
        {
            // Set the bottom object as the parent of the top object
            topObject.transform.SetParent(bottomObject.transform);
            
            // Optionally, reset the local position to make sure the top object stays at the same spot
            topObject.transform.localPosition = new Vector3(0, 1, 0);  // Adjust the position as needed
        }
        else
        {
            Debug.LogError("Top or bottom object not assigned in the Inspector.");
        }
    }
}
  