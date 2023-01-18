using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Ball;
    Vector3 distance;


    void Start()
    {
        
        distance = transform.position - Ball.transform.position;
    }

    void Update()
    {
        transform.position = Ball.transform.position + distance;



    }
}
