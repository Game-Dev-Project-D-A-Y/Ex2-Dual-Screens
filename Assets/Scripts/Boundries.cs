using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component gives boundries to the object we will return the object to the center
 * of the map as soon as he reaches his limit.
 */
public class Boundries : MonoBehaviour
{
    float rightLimit;

    float leftLimit;

    float topLimit;

    float bottomLimit;

    // Start is called before the first frame update
    void Start()
    {
        GameObject streetObject = GameObject.Find("Street");
        Transform streetTransform = streetObject.GetComponent<Transform>();
        RectTransform streetRect = streetObject.GetComponent<RectTransform>();

        float streetWidth = streetRect.rect.width;
        float streetHeight = streetRect.rect.height;
        float streetScaleX = streetRect.transform.localScale.x;
        float streetScaleY = streetRect.transform.localScale.y;

        rightLimit = ( (streetWidth * streetScaleX) / 2 - streetScaleX / (streetWidth * 2) ) / 2.2f;
        leftLimit = -1 * rightLimit;

        topLimit = ( (streetHeight * streetScaleY) / 2 - streetScaleY / (streetHeight * 2) ) / 2.1f;
        bottomLimit = -1 * topLimit;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, leftLimit, rightLimit);
        pos.y = Mathf.Clamp(pos.y, bottomLimit, topLimit);
        transform.position = pos;
    }
}
