using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] float startingBalance = 150f;
    [SerializeField] float currentBalance;

    [SerializeField] TMP_Text bankText;

    public float CurrentBalance { get { return currentBalance;  } }
    // Start is called before the first frame update
    void Awake()
    {
        currentBalance = startingBalance;

        bankText.text = "Gold : " + currentBalance;
    }

  

    public void Transaction(float amount)
    {
        currentBalance += amount;
        bankText.text = "Gold : " + currentBalance;

        if (currentBalance < 0)
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
