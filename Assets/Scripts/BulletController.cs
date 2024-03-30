using UnityEngine;

public class BulletController : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BounceObject")) // Adjust the tag as per your NPC prefab
        {
            NPCController npc = collision.gameObject.GetComponent<NPCController>();
            if (npc != null)
            {
                npc.Despawn(); // Trigger despawning of the NPC
            }
            Destroy(gameObject); // Destroy the bullet object upon collision

        }
    }
}
