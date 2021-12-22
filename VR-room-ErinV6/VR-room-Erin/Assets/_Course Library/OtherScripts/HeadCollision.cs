using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollision : MonoBehaviour
{

    public Animator fade;
    /*void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Wall")
        {
            Debug.Log("hit a wall!");
        }
        Debug.Log("not a wall i guess...");
    }*/

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("hit a wall ONTRIGGER!");
            fade.Play("fadeStart");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("LEFT THE WALLLL");
            fade.Play("fadeEnd");
        }
    }
}
