using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public TMP_Text healthText;
    public AudioSource dangerSound;
    private bool isTakingDamage = false;
    
    

    void Start() {
        UpdateHealthDisplay();

    }

    void UpdateHealthDisplay()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + GameManager.gameManager._playerHealth.Health.ToString();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BounceObject"))
        {
            PlayerTakeDamage(5);
            dangerSound.Play();
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
    }
    void OnCollisionStay(Collision collision)
    {   
        if (collision.gameObject.CompareTag("BounceObject") && !isTakingDamage)
        {
            StartCoroutine(ApplyDamageWithDelay(3)); // Start the coroutine to apply damage with a delay
        }
    }

    // Coroutine to apply damage with a delay
    IEnumerator ApplyDamageWithDelay(float delay)
    {
        isTakingDamage = true; // Set the flag to indicate that damage is being applied
        PlayerTakeDamage(5); // Apply the damage
        dangerSound.Play(); // Play the danger sound
        Debug.Log(GameManager.gameManager._playerHealth.Health); // Log player health
        
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        isTakingDamage = false; // Reset the flag after the delay
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.O)) {
            PlayerTakeDamage(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }

        if(Input.GetKeyDown(KeyCode.P)) {
            PlayerHeal(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
         
        
    }

    private void PlayerTakeDamage(int dmg) {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
        UpdateHealthDisplay();
    }

    private void PlayerHeal(int healing) {
        GameManager.gameManager._playerHealth.HealUnit(healing);
        UpdateHealthDisplay();
        
    }
}
