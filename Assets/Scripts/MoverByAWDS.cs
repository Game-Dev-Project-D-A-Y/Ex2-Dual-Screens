using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component is responsible for moving the object using the A S D W  keys .
 */

public class MoverByAWDS : MonoBehaviour
{

    [SerializeField]
    float step = 0.05f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, step, 0);
        }

        if (Input.GetKey("s"))
        {
            transform.position -= new Vector3(0, step, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(step, 0, 0);
        }
        
        if (Input.GetKey("a"))
        {
            transform.position -= new Vector3(step, 0, 0);
        }

    }
}