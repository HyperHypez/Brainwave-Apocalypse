using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionHandler : MonoBehaviour
{
    public float bounceForce = 10f; // Adjust this value to control the intensity of the bounce
    public PhysicMaterial bounceMaterial; // Assign your Physics Material in the Inspector

    private bool hasBounced = false;

    void OnCollisionEnter(Collision collision)
    {


        if(collision.gameObject.CompareTag("Checkpoint"))
        {
            SceneManager.LoadScene("Outro");
        }

        if (!hasBounced && collision.gameObject.CompareTag("BounceObject")) // Adjust the tag as per your NPC prefab
        {
            // Calculate the direction of the bounce (opposite to the normal of collision)
            Vector3 bounceDirection = -collision.contacts[0].normal;
            
            // Apply the bouncing effect to the player's position or velocity
            // Example: Change player's position based on the bounce direction
            transform.position += bounceDirection * bounceForce * Time.deltaTime;

            // Apply Physics Material
            Collider playerCollider = GetComponent<Collider>();
            if (playerCollider != null && bounceMaterial != null)
            {
                playerCollider.material = bounceMaterial;
            }

            // Set flag to prevent repeated bouncing
            hasBounced = true;

            // Reset Physics Material after a delay (adjust this delay as needed)
            Invoke("ResetPhysicsMaterial", 0.5f);
        }
    }

    void ResetPhysicsMaterial()
    {
        Collider playerCollider = GetComponent<Collider>();
        if (playerCollider != null && bounceMaterial != null)
        {
            playerCollider.material = null;
        }
        hasBounced = false; // Reset flag for future collisions
    }
}
