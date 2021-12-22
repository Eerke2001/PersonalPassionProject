using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroTextChange : MonoBehaviour
{
    public TextMeshProUGUI Textfield;
    public Button startButton;
    public Sprite NextButton;
    public Sprite YesButton;
    public Animator crossFade;

    int keepNumber = 0;

    void Start()
    {
        Button startbtn = startButton.GetComponent<Button>();
        startbtn.onClick.AddListener(SetText);
    }

    public void LoadButtonNext()
    {
        //Start loading the Scene asynchronously and output the progress bar
        StartCoroutine(StartOnClick());
    }

    IEnumerator StartOnClick()
    {
        crossFade.Play("fadeStart");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
        crossFade.Play("fadeEnd");
    }

    void SetText()
    {

        keepNumber++;

        if (keepNumber == 0)
        {
            Textfield.text = "Hi there!";
        }
        else if (keepNumber == 1)
        {
            Textfield.text = "The view here is amazing! But you know it won't last too long anymore!";
        }
        else if (keepNumber == 2)
        {
            Textfield.text = "Your oxygen is getting low, you should return to the main post.";
        }
        else if (keepNumber == 3)
        {
            Textfield.text = "... ah, the ship!";
        }
        else if (keepNumber == 4)
        {
            Textfield.text = "Are you sure you still want to take a look at the inside?";
            Button startimg = startButton.GetComponent<Button>();
            startimg.GetComponent<Image>().sprite = YesButton;
        }
        else if (keepNumber == 5)
        {
            Textfield.text = "Allright, but make it quick!";
            Button startbtn = startButton.GetComponent<Button>();
            startbtn.GetComponent<Image>().sprite = NextButton;
            startbtn.onClick.AddListener(LoadButtonNext);
        }/*
        else if (keepNumber == 6)
        {
            Button startbtnNext = startButton.GetComponent<Button>();
            startbtnNext.onClick.AddListener(LoadButtonNext);
        }*/
    }

   /* void SetText()
    {
        keepNumber++;
    }*/
}
