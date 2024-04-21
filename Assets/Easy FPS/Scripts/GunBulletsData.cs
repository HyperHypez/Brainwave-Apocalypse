using UnityEngine;


[CreateAssetMenu(fileName = "GunBulletsData", menuName = "ScriptableObjects/GunBulletsData", order = 1)]
public class GunBulletsData : ScriptableObject
{
    public float bulletsIHave = 20;
    public float bulletsInTheGun = 5;
    public float amountOfBulletsPerLoad = 5;

    float originalBulletsIHave;
    float originalBulletsInTheGun;
    float originalAmountOfBulletsPerLoad;


    void Awake()
    {
        originalBulletsIHave = bulletsIHave;
        originalBulletsInTheGun = bulletsInTheGun;
        originalAmountOfBulletsPerLoad = amountOfBulletsPerLoad;
    }

    void Reset()
    {
        bulletsIHave = originalBulletsIHave;
        bulletsInTheGun = originalBulletsInTheGun;
        amountOfBulletsPerLoad = originalAmountOfBulletsPerLoad;
    }

    void OnDisable()
    {
        Reset();
    }
    
    
}
