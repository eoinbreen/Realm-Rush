using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] float startingBalance = 150f;
    [SerializeField] float currentBalance;

    public float CurrentBalance { get { return currentBalance;  } }
    // Start is called before the first frame update
    void Awake()
    {
        currentBalance = startingBalance;
    }

  

    public void Transaction(float amount)
    {
        currentBalance += amount;
        
        if(currentBalance < 0)
        {
            reloadScene();
        }
    }

    void reloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
