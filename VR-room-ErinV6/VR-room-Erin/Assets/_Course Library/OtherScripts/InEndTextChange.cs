using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InEndTextChange : MonoBehaviour
{
    public TextMeshProUGUI Textfield;

    public Button startButton;
    public GameObject startBtn;

    public Animator crossFade;
    public Button PlayAgainBtn;
    public GameObject JoshCanvas;

    int keepNumber = 0;

    void Start()
    {
        Button startbtn = startButton.GetComponent<Button>();
        startbtn.onClick.AddListener(SetText);

        Button againbtn = PlayAgainBtn.GetComponent<Button>();
        againbtn.onClick.AddListener(LoadButtonNext);

        JoshCanvas.SetActive(true);
    }

    public void LoadButtonNext()
    {
        //Start loading the Scene asynchronously and output the progress bar
        StartCoroutine(StartOnClick());
    }

    IEnumerator ByeJosh()
    {
        yield return new WaitForSeconds(2f);
        JoshCanvas.SetActive(false);
    }

    IEnumerator StartOnClick()
    {
        crossFade.Play("fadeStart");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
        crossFade.Play("fadeEnd");
    }

    void SetText()
    {

        keepNumber++;

        if (keepNumber == 0)
        {
            Textfield.text = "Are... Are you OK?";
        }
        else if (keepNumber == 1)
        {
            Textfield.text = "Thank God! That was getting close!";
        }
        else if (keepNumber == 2)
        {
            Textfield.text = "Well, you made it, so I'm gonna leave. ";
        }
        else if (keepNumber == 3)
        {
            startBtn.SetActive(false);
            Textfield.text = "See ya!";
            StartCoroutine(ByeJosh());
        }/*
        else if (keepNumber == 6)
        {
            Button startbtnNext = startButton.GetComponent<Button>();
            startbtnNext.onClick.AddListener(LoadButtonNext);
        }*/
    }
}
