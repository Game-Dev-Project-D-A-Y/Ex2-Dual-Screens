using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component is responsible for moving the object using the Arrows keys .
 */
public class MoverByArrows : MonoBehaviour
{
    
    [Tooltip("Change step size")]
    [SerializeField]
    float step;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, step, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0, step, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(step, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(step, 0, 0);
        }
    }
}
