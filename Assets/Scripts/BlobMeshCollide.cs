using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobMeshCollide : MonoBehaviour
{
    Mesh blob;
    SkinnedMeshRenderer rend;
    Rigidbody rigid;
    Vector3[] vertices;
    GameObject[] ObjectList;
    Collider[] ColliderList;
    Vector3 floorPush;
    Vector3 vel;
    Vector3 rand;
    Cloth cloth;
    

    // Start is called before the first frame update
    void Start()
    {
        //Generate list of colliders for blob to interact with
        ObjectList = new GameObject[GameObject.FindGameObjectsWithTag("env").Length];
        ObjectList = GameObject.FindGameObjectsWithTag("env");
        ColliderList = new Collider[ObjectList.Length];
        for (int i = 0; i < ObjectList.Length; i++)
        {
            ColliderList[i] = ObjectList[i].GetComponent<Collider>();
        }

        // create array of vertices to modify
        blob = GetComponent<MeshFilter>().mesh;
        vertices = new Vector3[blob.vertexCount];

        //get mesh renderer
        rend = GetComponent<SkinnedMeshRenderer>();

        //get rigidbody
        rigid = GetComponent<Rigidbody>();
        floorPush = new Vector3(0.0f, 9.81f, 0.0f);

        //get Cloth
        cloth = GetComponent<Cloth>();

    }
    /*
    private void FixedUpdate()
    {
        //get position of mesh vertices
        vertices = blob.vertices;


        //get velocity
        vel = new Vector3(0, -rigid.velocity.y, 0);

        //get random vector
        rand = new Vector3(Random.Range(-0.5f,0.5f), -0.5f, Random.Range(-0.5f, 0.5f));
        //Find position of vertices
        for (int j = 0; j < ColliderList.Length; j++)
         {
            // for (int i = 0; i < vertices.Length; i++)
             //{

                 //if vertex is in bounds of a collider, move it to nearest point outside
                // if (ColliderList[j].bounds.Contains(transform.TransformPoint(vertices[i])))
                 //if(rend.bounds.Intersects(ColliderList[j].bounds))
                 
                 {
                     Debug.Log("Working?");
                    //rigid.constraints = RigidbodyConstraints.FreezePositionY;
                    //vertices[i] = ColliderList[j].ClosestPointOnBounds(transform.TransformPoint(vertices[i]));
                    rigid.AddForce(vel, ForceMode.VelocityChange);
                    rigid.AddForce(floorPush, ForceMode.Force);
                    //rigid.AddForceAtPosition(floorPush/(blob.vertexCount), rand);
                    cloth.externalAcceleration = floorPush;
                 }
                 else {
                    Debug.Log("false");
                    cloth.externalAcceleration = Vector3.zero;
                }
             //}
         }

        //store updated vertices into mesh
        
        //for (int i = 0; i < vertices.Length; i++) {
           // vertices[i] = transform.TransformPoint(vertices[i]);
            //vertices[i].y = Mathf.Max(vertices[i].y, 0);
            //vertices[i] = transform.InverseTransformPoint(vertices[i]);
                //}
        
       
        
        //update bounds of mesh
        blob.vertices = vertices;
        blob.RecalculateBounds();
    }
    
    private void OnTriggerStay()
    {
        rigid.AddForce(vel, ForceMode.VelocityChange);
        rigid.AddForce(floorPush, ForceMode.Force);
        //rigid.AddForceAtPosition(floorPush/(blob.vertexCount), rand);
        cloth.externalAcceleration = floorPush;
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("false");
        cloth.externalAcceleration = Vector3.zero;
    }

    */
    // Update is called once per frame
    void Update()
    {

    }
}
