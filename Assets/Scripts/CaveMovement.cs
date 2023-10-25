using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;
public class CaveMovement : MonoBehaviour
{
    private float xwalkingspeed;
    private float ywalkingspeed;
    public bool cave;
    public float xDirection;
    public float yDirection;
    public float xVector;
    public float yVector;
    public Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        xwalkingspeed = 4;
        ywalkingspeed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
        {
            cave = false;
        }
        else
        {
            cave = true;
        }

        if (cave)
        {
            ywalkingspeed = 0;
        }
        xDirection = Input.GetAxis("Horizontal");
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * ywalkingspeed * Time.deltaTime;
        xVector = xDirection * xwalkingspeed * Time.deltaTime;
        transform.Translate(new Vector3(xVector, yVector, 0));
        
    }

}




