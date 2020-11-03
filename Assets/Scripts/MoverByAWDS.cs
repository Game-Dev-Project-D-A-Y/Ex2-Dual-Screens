using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component is responsible for moving the object using the A S D W  keys .
 */

public class MoverByAWDS : MonoBehaviour
{

    [SerializeField]
    float step;

    void Start()
    {
        step = 0.05f;
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