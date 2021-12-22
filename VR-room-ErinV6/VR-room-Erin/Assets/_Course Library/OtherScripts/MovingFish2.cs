using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFish2 : MonoBehaviour
{
    private Vector3 _rotation = new Vector3(0, -40, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
