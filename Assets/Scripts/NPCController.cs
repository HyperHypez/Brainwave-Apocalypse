using UnityEngine;

public class NPCController : MonoBehaviour
{
    public void Despawn()
    {   
        // Perform any despawning logic here
        Destroy(gameObject); // Example: Destroy the NPC object
    }
}
