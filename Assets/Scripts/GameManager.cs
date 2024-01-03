using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int coinCount = 0;
    public TMP_Text coinText;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        UpdateGUI();
    }
    public void IncrementCoinCount()
    {
        coinCount += 1;
        UpdateGUI();
    }
    public void UpdateGUI()
    {
        coinText.text = coinCount.ToString();
    }
}
