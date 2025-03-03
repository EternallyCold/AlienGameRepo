using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 50;
    private int currentHealth;
    public void Kill()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int changeAmount)
    {
        currentHealth = currentHealth + changeAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
        if (currentHealth == 0)
        {
            Kill();
        }
    }

    //this function is a custom function to give the current health to the calling code
    public int GetHealth()
    {
        return currentHealth;
    }

}
