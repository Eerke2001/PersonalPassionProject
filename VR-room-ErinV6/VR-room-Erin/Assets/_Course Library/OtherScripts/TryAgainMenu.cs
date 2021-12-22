using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainMenu : MonoBehaviour
{

    public Button tryAgainButton;
    public Button menuButton;

    public Animator crossFade;

    // Start is called before the first frame update
    void Start()
    {
        Button trybtn = tryAgainButton.GetComponent<Button>();
        trybtn.onClick.AddListener(LoadTryButton);

        Button menbtn = menuButton.GetComponent<Button>();
        menbtn.onClick.AddListener(LoadMenuButton);
    }

    void LoadTryButton()
    {
        StartCoroutine(StartTryOnClick());
    }

    void LoadMenuButton()
    {
        StartCoroutine(StartMenuOnClick());
    }

    IEnumerator StartTryOnClick()
    {
        crossFade.Play("fadeStart");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
        crossFade.Play("fadeEnd");
    }

    IEnumerator StartMenuOnClick()
    {
        crossFade.Play("fadeStart");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(1);
        crossFade.Play("fadeEnd");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
