using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    [SerializeField] float startingBalance = 150f;
    [SerializeField] float currentBalance;

    public float CurrentBal { get { return currentBalance;  } }
    // Start is called before the first frame update
    void Awake()
    {
        currentBalance = startingBalance;
    }

  

    public void Transaction(float amount)
    {
        currentBalance += amount;
    }
}
