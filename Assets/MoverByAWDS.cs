using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */

public class MoverByAWDS : MonoBehaviour
{
    float step = 0.01f;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, step, 0);
            Debug.Log("up");
        }
        if (Input.GetKey("s"))
        {
            transform.position -= new Vector3(0, step, 0);
            Debug.Log("down");
        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(step, 0, 0);
            Debug.Log("right");
        }
        if (Input.GetKey("a"))
        {
            transform.position -= new Vector3(step, 0, 0);
            Debug.Log("left");

        }

    }
}