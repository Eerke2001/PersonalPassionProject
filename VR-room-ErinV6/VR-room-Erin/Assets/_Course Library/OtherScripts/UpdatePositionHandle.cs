using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePositionHandle : MonoBehaviour
{

    public Transform handler;

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Hands")
        {
            transform.position = handler.transform.position;

            Rigidbody rbhandler = handler.GetComponent<Rigidbody>();
            rbhandler.velocity = Vector3.zero;
            rbhandler.angularVelocity = Vector3.zero;
        }
    }

    private void Update()
    {
        if(Vector3.Distance(handler.position, transform.position) > 0.4f)
        {
        }
    }
}
