using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicLockChest : MonoBehaviour
{

    public GameObject grabHandler;

    public GameObject mirrorSpawn;

    // Start is called before the first frame update
    void Start()
    {
        grabHandler.SetActive(false);
        mirrorSpawn.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "KeyChest")
        {
            grabHandler.SetActive(true);
            mirrorSpawn.SetActive(true);
        }

    }
}
