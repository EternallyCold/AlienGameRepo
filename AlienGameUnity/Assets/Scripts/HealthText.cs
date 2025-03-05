using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    Text healthValue;
    PlayerHealth player;
    
    // Start is called before the first frame update
    void Start()
    {
        healthValue = GetComponent<Text>();

        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        healthValue.text = player.GetHealth().ToString();
    }
}
