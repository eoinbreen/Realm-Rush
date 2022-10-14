using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHP = 5;
    int currentHP;
    private void Start()
    {
        currentHP = maxHP;
    }
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }
    void ProcessHit()
    {
        currentHP--;
        print(name + " HP is now " + currentHP);

        if(currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
