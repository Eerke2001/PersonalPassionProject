using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCardLogic : MonoBehaviour
{

    public bool checkLaserButtonPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "KeyCard")
        {
            checkLaserButtonPressed = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "KeyCard")
        {
            checkLaserButtonPressed = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
