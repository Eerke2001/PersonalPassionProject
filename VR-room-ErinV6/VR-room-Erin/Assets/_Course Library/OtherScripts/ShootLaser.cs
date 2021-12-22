using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public Material material;
    LaserBeam beam;

    public bool checkBoolLaser = false;
    public bool boolDestroyFinal = false;

    private float duration = 1f;

    IEnumerator WaitDestroy()
    {
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            Destroy(GameObject.Find("Laser Beam"));
            beam = new LaserBeam(gameObject.transform.position, gameObject.transform.up, material);

            elapsedTime += Time.deltaTime;

            yield return null;

        }

        Debug.Log(GameObject.Find("Laser Beam"));
        boolDestroyFinal = true;
        Destroy(GameObject.Find("Laser Beam"));
        
    }

    // Update is called once per frame
    void Update()
    {

        if (checkBoolLaser ==  false)
        {
            Destroy(GameObject.Find("Laser Beam"));
            beam = new LaserBeam(gameObject.transform.position, gameObject.transform.up, material);

            if (beam.checkReceive == true)
            {
                Debug.Log(beam.checkReceive);
                StartCoroutine(WaitDestroy());
                checkBoolLaser = true;
            }
        }
        else
        {
            if (boolDestroyFinal == true)
            {
                Destroy(GameObject.Find("Laser Beam"));
            }
        }

    }
}
