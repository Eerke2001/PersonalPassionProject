using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckPuzzleComplete : MonoBehaviour
{

    public TextMeshProUGUI Textfield;

    public Button startButton;
    public GameObject startBtn;

    public GameObject joshCanvas;

    int keepNumberPuzz = 0;

    public bool checkPuzzleCompl = false;

    //------------------------------------------------//

    public GameObject topL;
    private CheckPuzzleSocket topL_bool;

    public GameObject topM;
    private CheckPuzzleSocket topM_bool;

    public GameObject topR;
    private CheckPuzzleSocket topR_bool;

    public GameObject midL;
    private CheckPuzzleSocket midL_bool;

    public GameObject midM;
    private CheckPuzzleSocket midM_bool;

    public GameObject midR;
    private CheckPuzzleSocket midR_bool;

    public GameObject bottomL;
    private CheckPuzzleSocket bottomL_bool;

    public GameObject bottomM;
    private CheckPuzzleSocket bottomM_bool;

    public GameObject bottomR;
    private CheckPuzzleSocket bottomR_bool;


    // Start is called before the first frame update
    void Start()
    {
        topL_bool = topL.GetComponent<CheckPuzzleSocket>();
        topM_bool = topM.GetComponent<CheckPuzzleSocket>();
        topR_bool = topR.GetComponent<CheckPuzzleSocket>();
        midL_bool = midL.GetComponent<CheckPuzzleSocket>();
        midM_bool = midM.GetComponent<CheckPuzzleSocket>();
        midR_bool = midR.GetComponent<CheckPuzzleSocket>();
        bottomL_bool = bottomL.GetComponent<CheckPuzzleSocket>();
        bottomM_bool = bottomM.GetComponent<CheckPuzzleSocket>();
        bottomR_bool = bottomR.GetComponent<CheckPuzzleSocket>();

    }

    // Update is called once per frame
    void Update()
    {
        if (topL_bool.checkPuzz == true && topM_bool.checkPuzz == true && topR_bool.checkPuzz == true)
        {
            if (midL_bool.checkPuzz == true && midM_bool.checkPuzz == true && midR_bool.checkPuzz == true)
            {
                if (bottomL_bool.checkPuzz == true && bottomM_bool.checkPuzz == true && bottomR_bool.checkPuzz == true)
                {
                    if (checkPuzzleCompl == false)
                    {
                        Button startbtn = startButton.GetComponent<Button>();
                        startbtn.onClick.AddListener(SetText);

                        startBtn.SetActive(true);

                        joshCanvas.SetActive(true);
                        Textfield.text = "You found a puzzle?";

                        checkPuzzleCompl = true;
                    }
                    
                }
            }
        }
    }

    void CloseJosh()
    {
        joshCanvas.SetActive(false);
    }

    void SetText()
    {

        keepNumberPuzz++;

        if (keepNumberPuzz == 0)
        {
            Textfield.text = "You found a puzzle?";
        }
        else if (keepNumberPuzz == 1)
        {
            Textfield.text = "I would look closely at the image. It might be usefull later!";
            Button startbtn = startButton.GetComponent<Button>();
            startbtn.onClick.AddListener(CloseJosh);
        }
    }
}
