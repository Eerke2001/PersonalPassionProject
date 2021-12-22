using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPhysicsFast : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Vector3 posVec = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z * 0.3f);
        rb.MovePosition(target.transform.position);
        //Debug.Log(target.transform.position.z);
    }
}
