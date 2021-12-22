using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public float maxHealth = 200;
    public float currentHealth;

    public Animator crossFade;

    public bool checkDeath = false;

    //public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;

        //gameOverCanvas.SetActive(false);

        //healthBar.SetMaxHealth(maxHealth);
    }

    IEnumerator StartGameOver()
    {
        crossFade.Play("fadeStart");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(3);
        crossFade.Play("fadeEnd");
    }

    void Update()
    {
        currentHealth -= 1 * Time.deltaTime;
        slider.value = currentHealth;
        //Debug.Log(slider.value);

        if (checkDeath == false)
        {
            if (slider.value <= 0)
            {
                //gameOverCanvas.SetActive(true);
                StartCoroutine(StartGameOver());

                checkDeath = true;
                Debug.Log("hallo tis al lang game over");
            }
        }
        

        //healthBar.SetHealth(currentHealth);
    }

    /*public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }*/

    /*public void SetHealth(int health)
    {
        slider.value = health;
    }*/
}
