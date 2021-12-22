using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{

    public GameObject getShootLaser;
    private ShootLaser bool_script;

    public AudioSource explosion;

    public Animator canonAnim;

    public GameObject redGlow;

    public bool checkBoolRoutine = false;
    public bool shootBallAnim = false;

    // Start is called before the first frame update
    void Start()
    {
        bool_script = getShootLaser.GetComponent<ShootLaser>();
        canonAnim = GetComponent<Animator>();

        redGlow.SetActive(false);

        explosion.time = 0.05f;
        explosion.Play();

    }

    IEnumerator PlayAnimation()
    {
        redGlow.SetActive(true);
        yield return new WaitForSeconds(1f);
        canonAnim.Play("CanonAnim");
        shootBallAnim = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (bool_script.checkBoolLaser == true)
        {
            if (checkBoolRoutine == false)
            {
                StartCoroutine(PlayAnimation());
                checkBoolRoutine = true;
            } 
        }   
    }
}
