using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private HUD Gm;
    
    // Start is called before the first frame update
    void Start()
    {
        Gm = GameObject.FindObjectOfType<HUD>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Gm.coins ++;
            other.gameObject.SetActive(false);
        }
    }
}
