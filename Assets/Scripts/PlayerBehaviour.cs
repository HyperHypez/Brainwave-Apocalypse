using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public TMP_Text healthText;
    public AudioSource dangerSound;
    
    

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
            PlayerTakeDamage(10);
            dangerSound.Play();
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
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
