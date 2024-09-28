using UnityEngine;

public class BallTeleport : MonoBehaviour
{
    [System.Serializable]
    public struct TeleportPair
    {
        public Transform torusA;  
        public Transform torusB;  
    }

    public TeleportPair[] teleportPairs;  
    public float teleportHeightOffset = 2f;  
    private bool isTeleporting = false; 

    void OnTriggerEnter(Collider other)
    {
        if (isTeleporting)
            return;  

        // Check if the ball collided with a torus (tagged "Teleporter")
        foreach (var pair in teleportPairs)
        {
            if (other.transform == pair.torusA)
            {
                TeleportTo(pair.torusB);
                break;
            }
            else if (other.transform == pair.torusB)
            {
                TeleportTo(pair.torusA);
                break;
            }
        }
    }

    void TeleportTo(Transform targetTorus)
    {
        isTeleporting = true; 
        Vector3 teleportPosition = targetTorus.position + new Vector3(0, teleportHeightOffset, 0);  // Add height offset
        transform.position = teleportPosition; 
        StartCoroutine(TeleportCooldown()); 
    }

    // Prevent re-triggering teleportation too quickly
    System.Collections.IEnumerator TeleportCooldown()
    {
        yield return new WaitForSeconds(0.9f); 
        isTeleporting = false;
    }
}
