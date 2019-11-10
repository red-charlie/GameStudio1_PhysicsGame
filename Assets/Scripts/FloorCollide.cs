using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollide : MonoBehaviour
{
    Transform[] boneList;
    Bounds[] boundList;
    GameObject[] ObjectList;
    Collider[] ColliderList;
    // Start is called before the first frame update
    void Start()
    {
        ObjectList = new GameObject[GameObject.FindGameObjectsWithTag("env").Length];
        ObjectList = GameObject.FindGameObjectsWithTag("env");
        ColliderList = new Collider[ObjectList.Length];
        for (int i = 0; i<ObjectList.Length; i++)
        {
            ColliderList[i] = ObjectList[i].GetComponent<Collider>();
        }
        
    }


    private void FixedUpdate()
    {
        boneList = GetComponent<SkinnedMeshRenderer>().bones;
        for (int i = 0; i < boneList.Length; i++)
        {
            for (int j = 0; j < ColliderList.Length; j++)
            {
                if (ColliderList[j].bounds.Contains(boneList[i].position))
                {
                    boneList[i].position = ColliderList[j].ClosestPointOnBounds(boneList[i].position);
                }
            }

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
