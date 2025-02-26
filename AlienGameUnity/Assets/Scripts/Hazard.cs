using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //code to handle collision
        Collider2D collider = collision.collider;
        PlayerHealth player = collider.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.Kill();
        }
        
    }
    
}
