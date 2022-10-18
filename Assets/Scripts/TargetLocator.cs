using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] ParticleSystem projectileParticles;
    [SerializeField] float range = 15f;
    Transform target;

    // Update is called once per frame
    void Update()
    {
        FindClosestTarget();
        AimWeapon();
    }

    void FindClosestTarget()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        float minDistance = Mathf.Infinity;
        float thisDistance;

        foreach (Enemy enemy in enemies)
        {
            thisDistance = Vector3.Distance(gameObject.transform.position, enemy.transform.position);
            if(thisDistance < minDistance)
            {
                minDistance = thisDistance;
                target = enemy.transform;
            }
        }
    }

    void AimWeapon()
    {
        float targetDistance = Vector3.Distance(gameObject.transform.position, target.transform.position);
        weapon.LookAt(target);
        if (targetDistance < range)
        {
            Attack(true);
        }
        else
        {
            Attack(false);
        }
    }

    void Attack(bool isAttacking)
    {
        var emissionModule = projectileParticles.emission;
        emissionModule.enabled = isAttacking;
    }
}
