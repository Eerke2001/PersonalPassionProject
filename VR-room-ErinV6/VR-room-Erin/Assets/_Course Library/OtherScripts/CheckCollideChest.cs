using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollideChest : MonoBehaviour
{

    public BoxCollider boxCollider;
    public MeshCollider meshCollider;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(boxCollider, meshCollider, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
