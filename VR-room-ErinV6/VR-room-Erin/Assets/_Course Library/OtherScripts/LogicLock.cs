using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicLock : MonoBehaviour
{

    public GameObject grabHandler;
    public GameObject grabHandlerTwo;
    public GameObject boxRoomTwo;

    // Start is called before the first frame update
    void Start()
    {
        grabHandler.SetActive(false);
        grabHandlerTwo.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Key")
        {
            grabHandler.SetActive(true);
            grabHandlerTwo.SetActive(true);
            boxRoomTwo.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
