using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Turret : MonoBehaviour
{

    private Vector3 target;
    private float timer = 0;
    private float timermax = 2;
    [SerializeField] private GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        projectile = GameObject.Find("Turret_Projectile");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
             timer-= Time.deltaTime;
        }
       

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") & timer <= 0 )
        {
            Rigidbody2D p = Instantiate()
            target = other.gameObject.transform.position;
            Instantiate(projectile,transform);
            timer = timermax;
        }
    }
}
