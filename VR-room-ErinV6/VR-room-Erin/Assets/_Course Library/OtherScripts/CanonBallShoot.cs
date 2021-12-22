using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanonBallShoot : MonoBehaviour
{

    public GameObject getGlobeStand;
    private CanonController bool_script;

    public MeshRenderer meshRenderer;

    public GameObject particleExplosionObj;
    public ParticleSystem explosion;

    public bool checkCanPlay = false;
    public bool moveCanonBallBool = false;

    public Animator fade;

    // Start is called before the first frame update
    void Start()
    {
        bool_script = getGlobeStand.GetComponent<CanonController>();

        meshRenderer.enabled = false;

        particleExplosionObj.SetActive(false);
        
    }

    IEnumerator PlayCanonBall()
    {

        yield return new WaitForSeconds(6.5f);
        meshRenderer.enabled = true;
        moveCanonBallBool = true;
        yield return new WaitForSeconds(0.5f);
        particleExplosionObj.SetActive(true);
        explosion.Play();
        yield return new WaitForSeconds(0.5f);
        fade.Play("fadeWhiteStart");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(4);
        fade.Play("fadeEnd");
    }

    // Update is called once per frame
    void Update()
    {
        if (bool_script.shootBallAnim == true)
        {
            if (checkCanPlay == false)
            {
                StartCoroutine(PlayCanonBall());
                checkCanPlay = true;
            }
            else if (moveCanonBallBool ==  true)
            {
                transform.position += transform.forward * Time.deltaTime * 4f;
            }
        }
    }
}
