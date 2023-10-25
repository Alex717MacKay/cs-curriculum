using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public static HUD Gm;
    public CollectCoins purse;
    public int coins;
    public int maxhealth;
    public int health;
    public Heath hp;

    public TextMeshProUGUI cointxt;

    public TextMeshProUGUI hptxt;
    // Start is called before the first frame update
    void Awake()
    {
        
        if (Gm != null && Gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    void Start()
    {
        coins = 0;
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        cointxt.text = "Coins: " + coins;
        hptxt.text = "Health: " + health;
    }
}
