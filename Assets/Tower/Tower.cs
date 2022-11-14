using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] float cost = 50f;
    [SerializeField] float buildDelay = 1f;

    private void Start()
    {
        StartCoroutine(Build());
    }

    public bool CreateTower(Tower tower, Vector3 position)
    {
        Bank bank = FindObjectOfType<Bank>();
        if(bank == null)
        { 
            return false;
        }

        if (bank.CurrentBalance >= cost)
        {
            bank.Transaction(-cost);
            Instantiate(tower, position, Quaternion.identity);
            return true;
        }
        else
        {
            print("You dont have the funds to create another tower!!");
            return false;
        }
    }

    IEnumerator Build()
    {
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(false);
            foreach (Transform grandChild in child.transform)
            {
                grandChild.gameObject.SetActive(false);
            }
        }
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
            yield return new WaitForSeconds(buildDelay);
            foreach (Transform grandChild in child.transform)
            {
                grandChild.gameObject.SetActive(true);
            }
        }
    }
}
