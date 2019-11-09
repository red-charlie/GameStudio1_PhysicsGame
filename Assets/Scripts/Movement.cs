using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 deltaX;
    Vector3 deltaZ;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 position = transform.position;
        deltaX = Vector3.right;
        deltaZ = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.position = transform.position - deltaX * (0.1f);
        }
        if (Input.GetKey("d"))
        {
            transform.position = transform.position + deltaX * 0.1f;
        }
        if (Input.GetKey("w"))
        {
            transform.position = transform.position + deltaZ * (0.1f);
        }
        if (Input.GetKey("s"))
        {
            transform.position = transform.position - deltaZ * (0.1f);
        }
    }
}
