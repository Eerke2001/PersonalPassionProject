using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckPuzzleSocket : MonoBehaviour
{

    public TextMeshProUGUI Textfield;

    public Button startButton;
    public GameObject startBtn;

    public GameObject joshCanvas;

    int keepNumberPuzz = 0;

    public GameObject puzzleSocket;

    public bool checkPuzz = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(puzzleSocket.name);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "PuzzlePiece" || other.gameObject.tag == "TopL" || other.gameObject.tag == "TopM" || other.gameObject.tag == "TopR" || other.gameObject.tag == "MidL" || other.gameObject.tag == "MidM" || other.gameObject.tag == "MidR" || other.gameObject.tag == "BottomL" || other.gameObject.tag == "BottomM" || other.gameObject.tag == "BottomR")
        {
            if (other.gameObject.tag == puzzleSocket.tag)
            {
                if (checkPuzz == false)
                {

                    /*Button startbtn = startButton.GetComponent<Button>();
                    startbtn.onClick.AddListener(SetText);

                    startBtn.SetActive(true);

                    joshCanvas.SetActive(true);
                    Textfield.text = "You found a puzzle?";*/

                    checkPuzz = true;
                }
                
            }
            
        }

    }

    /*void CloseJosh()
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
    }*/
}
