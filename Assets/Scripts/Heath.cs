using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Heath : MonoBehaviour
{
    private HUD Gm;
    // Start is called before the first frame update
    void Start()
    {
        Gm = GameObject.FindObjectOfType<HUD>();
    }
    void Update()
    {
            
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            Gm.health --;
        }
    }

    
}
