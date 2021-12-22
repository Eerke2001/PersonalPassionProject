using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLoader : MonoBehaviour
{

    public Button startButton;
    public Animator crossFade;

    // Start is called before the first frame update
    void Start()
    {
        Button startbtn = startButton.GetComponent<Button>();
        startbtn.onClick.AddListener(LoadButton);
    }

    void LoadButton()
    {
        //Start loading the Scene asynchronously and output the progress bar
        StartCoroutine(StartOnClick());
    }

    IEnumerator StartOnClick()
    {
        crossFade.Play("fadeStart");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
        crossFade.Play("fadeEnd");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
