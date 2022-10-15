using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float enemyWaitTime = 2f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    IEnumerator CreateEnemies()
    {
        while(true)
        {
            Instantiate(enemy, transform);
            yield return new WaitForSeconds(enemyWaitTime);
        }
    }
}
