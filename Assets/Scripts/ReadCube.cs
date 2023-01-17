using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ReadCube : MonoBehaviour
{
    public Transform tUp;
    public Transform tDown;
    public Transform tLeft;
    public Transform tRight;
    public Transform tFront;
    public Transform tBack;

    private int layerMask = 1 << 8; //This layermask is for the faces of the cube only

    CubeState cubestate;
    // Start is called before the first frame update
    void Start()
    {
        cubestate = FindObjectOfType<CubeState>();
    }

    // Update is called once per frame
    void Update()
    {
        List<GameObject> facesHit= new List<GameObject>();

        Vector3 ray = tFront.transform.position;
        RaycastHit hit;

        // Does the ray intersect any object in the layermask?

        if(Physics.Raycast(ray, tFront.right, out hit, Mathf.Infinity,layerMask))
        {
            Debug.DrawRay(ray, tFront.right * hit.distance, Color.yellow);
            facesHit.Add(hit.collider.gameObject);
            print(hit.collider.gameObject.name);
        }
        else
        {
            Debug.DrawRay(ray, tFront.right * 1000, Color.green);
        }
        cubestate.front = facesHit;
    }
}
