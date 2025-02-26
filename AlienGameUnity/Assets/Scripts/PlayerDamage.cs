using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            KillEnemy(collision.gameObject);
        }
        
    }
    public void KillEnemy(GameObject enemy)
    {
        Destroy(enemy);
    }
}
