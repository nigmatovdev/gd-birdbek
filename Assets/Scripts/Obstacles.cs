using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Obstacles : MonoBehaviour
{
    public float speed = 1.0f;

    private void FixedUpdate()
    {
        transform.position += ((Vector3.left * speed) * Time.deltaTime); 
    }
}
