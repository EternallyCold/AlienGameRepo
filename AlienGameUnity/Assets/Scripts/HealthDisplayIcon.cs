using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplayIcon : MonoBehaviour
{
    //health bar array because we have multiple game objects
    public GameObject[] healthIcons;

    PlayerHealth player;


    // Start is called before the first frame update
    void Start()
    {
        //search the scene for object with player health attached
        //store the playerhealth component from that object in our player variable
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //create a variable to keep track of which item in the list we are on
        //and how much health that icon is worth
        int iconHealth = 0;

        //go through each icon in the list
        //we will do everything inside brackets for each item in list
        //for each step in loop, store current list item in icon variable
        foreach (GameObject icon in healthIcons)
        {
            //each icon is worth 1 more health than the the last
            //so we get current health, add 1 and store result into iconHealth variable
            iconHealth = iconHealth + 1;

            //if players current health is = or >
            //than the health value for this icon...
            if (player.GetHealth() >= iconHealth)
            {
                //... then turn the icon on
                icon.SetActive(true);
            }
            //otherwise
            else
            {
                //...turn the icon off
                icon.SetActive(false);
            }
        }
    }
}
