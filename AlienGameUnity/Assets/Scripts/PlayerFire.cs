using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //unity editor variable which holds prefab reference
    public GameObject projectilePrefab;

    public Vector2 projectileVelocity;

    public void FireProjectile()
    {
        //clone the projectile

        //declare a variable to hold the cloned object
        GameObject clonedProjectile;

        //use instantiate function to clone projectile
        clonedProjectile = Instantiate(projectilePrefab);

        //position projectile on player
        clonedProjectile.transform.position = transform.position;

        //fire it in direction

        //declare a variable to hold onto the projectiles rigidbody
        Rigidbody2D projectileRigidbody;

        //get the rigidbody
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();

        //setting velocity on rigidbody to editor setting
        projectileRigidbody.velocity = projectileVelocity;
    }




}
