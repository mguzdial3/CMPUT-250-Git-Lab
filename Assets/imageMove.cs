using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageMove : MonoBehaviour
{
    public float speed = 3f;
    public float direction = -1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up*direction*Time.deltaTime*speed;

        if (transform.position.y > 3f || transform.position.y < -3f)
        {
            direction *= -1;
        }
    }
}
