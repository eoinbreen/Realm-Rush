using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] float cost = 50f;
   

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
}
