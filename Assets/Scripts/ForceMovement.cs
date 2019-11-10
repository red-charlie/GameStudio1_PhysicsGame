using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour
{
    Vector3 deltaX;
    Vector3 deltaZ;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 position = transform.position;
        deltaX = Vector3.right;
        deltaZ = Vector3.forward;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            rigidbody.AddForceAtPosition(-deltaX, transform.position + Vector3.up*0.2f);
        }
        if (Input.GetKey("d"))
        {
            rigidbody.AddForceAtPosition(deltaX, transform.position + Vector3.up * 0.2f);
        }
        if (Input.GetKey("w"))
        {
            rigidbody.AddForceAtPosition(deltaZ, transform.position + Vector3.up * 0.2f);
        }
        if (Input.GetKey("s"))
        {
            rigidbody.AddForceAtPosition(-deltaZ, transform.position + Vector3.up * 0.2f);
        }
    }
}
