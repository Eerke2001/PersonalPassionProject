using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainTextChange : MonoBehaviour
{
    public TextMeshProUGUI Textfield;

    public Button startButton;
    public GameObject startBtn;

    public Animator crossFade;

    public GameObject joshCanvas;

    int keepNumber = 0;

    void Start()
    {
        Button startbtn = startButton.GetComponent<Button>();
        startbtn.onClick.AddListener(SetText);

        joshCanvas.SetActive(true);
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

    IEnumerator ByeJosh()
    {
        yield return new WaitForSeconds(4f);
        joshCanvas.SetActive(false);
    }

    void SetText()
    {

        keepNumber++;

        if (keepNumber == 0)
        {
            Textfield.text = "... WHAT HAPPENED??";
        }
        else if (keepNumber == 1)
        {
            Textfield.text = "The whole ship was shaking??";
        }
        else if (keepNumber == 2)
        {
            Textfield.text = "You think it's a boobytrap and you're locked in??";
        }
        else if (keepNumber == 3)
        {
            startBtn.SetActive(false);
            Textfield.text = "That does not sound good... You better find a way out, and quick!";
            StartCoroutine(ByeJosh());
        }
        Debug.Log(keepNumber);
    }

   /* void SetText()
    {
        keepNumber++;
    }*/
}
