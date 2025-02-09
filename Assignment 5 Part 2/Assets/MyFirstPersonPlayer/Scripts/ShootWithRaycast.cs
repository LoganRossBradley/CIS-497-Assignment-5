﻿/*
 * Logan Ross
 * Assignment 5
 * Shoots gun and damages enemys
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycast : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    public ParticleSystem muzzleFlash;

    public float hitForce = 10f;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hitInfo;
        //if we hit something with our raycast
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            //get target script off hit object
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            //if target script found make it take damage
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }

        //add force to hit objects
        if (hitInfo.rigidbody != null)
        {
            hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
        }
    }
}
