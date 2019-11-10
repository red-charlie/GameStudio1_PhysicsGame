using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPhysics : MonoBehaviour
{
    GameObject blob;
    Rigidbody rigid;
    Cloth cloth;
    Vector3 floorPush;
    Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        blob = GameObject.FindGameObjectWithTag("avatar");
        rigid = blob.GetComponent<Rigidbody>();
        cloth = blob.GetComponent<Cloth>();
        floorPush = new Vector3(0.0f, 9.81f, 0.0f);
        vel = Vector3.zero;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //vel = new Vector3(0, -rigid.velocity.y, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        vel = new Vector3(0, -rigid.velocity.y, 0);
        rigid.AddForce(vel, ForceMode.VelocityChange);
    }
    void OnTriggerStay(Collider other)
    {
        vel = new Vector3(0, -rigid.velocity.y, 0);
        rigid.AddForce(vel, ForceMode.VelocityChange);
        rigid.AddForce(floorPush, ForceMode.Force);
        //rigid.AddForceAtPosition(floorPush/(blob.vertexCount), rand);
        cloth.externalAcceleration = floorPush;
    }

    private void OnTriggerExit(Collider other)
    {
        cloth.externalAcceleration = Vector3.zero;
    }
}
