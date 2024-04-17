using UnityEngine.SceneManagement;

public class UnitHealth
{
    // Fields
    int _currentHealth;
    int _currentMaxHealth;

    

    // Properties
    public int Health {
        get
        {
            return _currentHealth;
        }

        set
        {
            _currentHealth = value;
        }
    }

    public int MaxHealth {
        get
        {
            return _currentMaxHealth;
        }

        set
        {
            _currentMaxHealth = value;
        }
    }

    

    // Constructor
    public UnitHealth(int health, int maxHealth) {
        _currentHealth = health;
        _currentMaxHealth = maxHealth;
    }

    // Methods
    public void DmgUnit(int dmgAmount) {
        if (_currentHealth > 1) {
            _currentHealth -= dmgAmount;
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }

    public void HealUnit(int healAmount) {
        if (_currentHealth < _currentMaxHealth) {
            _currentHealth += healAmount;
        }

        if (_currentHealth > _currentMaxHealth) {
            _currentHealth = _currentMaxHealth;
        }
    }






}
