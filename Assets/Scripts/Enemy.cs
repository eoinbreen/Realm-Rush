using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float goldReward = 25;
    [SerializeField] float goldPenalty = 25;

    Bank bank;
    // Start is called before the first frame update
    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void rewardGold()
    {
        bank.Transaction(goldReward);
    }

    public void TakeGold()
    {
        bank.Transaction(-goldPenalty);
    }
}
