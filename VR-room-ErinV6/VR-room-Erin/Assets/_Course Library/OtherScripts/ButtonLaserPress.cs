using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLaserPress : MonoBehaviour
{

    public Animator laserBtnAnim;
    public bool checkPress = false;

    public AudioSource buttnClick;

    public GameObject laserPointer;

    public GameObject boolBtn;
    private KeyCardLogic bool_script;

    // Start is called before the first frame update
    void Start()
    {
        laserBtnAnim.Play("LaserButtonRelease");
        bool_script = boolBtn.GetComponent<KeyCardLogic>();

        laserPointer.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Hands")
        {
            laserBtnAnim.Play("LaserButtonPress");
            buttnClick.Play();

            if (bool_script.checkLaserButtonPressed == false)
            {
                Debug.Log("no card");
            }
            if (bool_script.checkLaserButtonPressed == true)
            {
                laserPointer.SetActive(true);
                Debug.Log("yes card");
            }

        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Hands")
        {
            laserBtnAnim.Play("LaserButtonRelease");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
