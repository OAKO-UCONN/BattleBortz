﻿using UnityEngine;

public class ProjectileWeapon : MonoBehaviour, IWeaponBehavior
{
    public void Fire()
    {
        Debug.Log("Firing Projectile");
    }
}
