using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVaultTurn : MonoBehaviour
{

    public GameObject keyCard;

    public Transform outerTurn;

    public Transform innerTurn;
    public Transform doorTurn;

    public GameObject innerTurnObj;
    public GameObject outerTurnObj;

    public GameObject innerTurnAnim;
    public GameObject outerTurnAnim;

    public float checkRotate = 0;
    public float duration = 3f;

    private Vector3 _rotationOuter = new Vector3(0, 0, 0);
    private Vector3 _rotationInner = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        keyCard.SetActive(false);

        outerTurn.transform.Rotate(_rotationOuter);
        innerTurn.transform.Rotate(_rotationInner);

        innerTurnAnim.SetActive(false);
        outerTurnAnim.SetActive(false);

        innerTurnObj.SetActive(true);
        outerTurnObj.SetActive(true);
    }

    IEnumerator OpenVault()
    {
        float elapsedTime = 0f;

        yield return new WaitForSeconds(1f);
        //Debug.Log("jaja");

        innerTurnAnim.SetActive(true);
        outerTurnAnim.SetActive(true);

        innerTurnObj.SetActive(false);
        outerTurnObj.SetActive(false);

        keyCard.SetActive(true);

        //doorTurn.transform.Rotate(new Vector3(0f, 40f, 0f) * Time.deltaTime);

        while (elapsedTime < duration)
        {
            doorTurn.transform.Rotate(new Vector3(0f, 40f, 0f) * Time.deltaTime);
            
            elapsedTime += Time.deltaTime;

            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (outerTurn.transform.rotation.eulerAngles.x > 82 && outerTurn.transform.rotation.eulerAngles.x < 90)
        {
            if (innerTurn.transform.rotation.eulerAngles.x > 272 && innerTurn.transform.rotation.eulerAngles.x < 279)
            {
                if (checkRotate == 0)
                {
                    //OpenVault();
                    StartCoroutine(OpenVault());
                    //Debug.Log(outerTurn.transform.rotation.eulerAngles.x);
                    Debug.Log("HEEEELLLL AAAAAAA YESSSSSS");
                    checkRotate++;
                }
                
            }
        }

        //outerTurn.transform.Rotate(new Vector3(40f, 0f, 0f) * Time.deltaTime);

        //outerTurn.position = new Vector3(followCube.position.x, followCube.position.y, followCube.position.z);

        //Debug.Log(innerTurn.transform.rotation.eulerAngles.x);
    }
}
