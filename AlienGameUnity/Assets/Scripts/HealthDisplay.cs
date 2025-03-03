using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //healthbar's address
    Slider healthBar;
    //player health address
    PlayerHealth player;



    // Start is called before the first frame update
    void Start()
    {
        //getting slider components off this game object and storing in healthbar variable
        healthBar = GetComponent<Slider>();
        //searching entire scene for player health component and storing it in player variable
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //create temporary float variables to use float division
        float currentHealth = player.GetHealth();
        float maxHealth = player.startingHealth;
        
        //slider value should be between 0 and 1, 0 is empty and 1 is full
        healthBar.value = currentHealth / maxHealth;

    }
}
