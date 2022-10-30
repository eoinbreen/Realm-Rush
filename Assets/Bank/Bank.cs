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

        UpdateDisplay();
    }

  

    public void Transaction(float amount)
    {
        currentBalance += amount;
        UpdateDisplay();

        if (currentBalance < 0)
        {
            reloadScene();
        }
    }

    void UpdateDisplay()
    {
        bankText.text = "Gold : " + currentBalance;
    }

    void reloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
