using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonTrigger : MonoBehaviour
{
    public static event Action onButtonPressed;
    private Animator _buttonAnimator;
    public GameObject uiHeader;
    public Animator bookAnim;

    // Start is called before the first frame update
    void Start()
    {
        _buttonAnimator = GetComponent<Animator>();
        bookAnim = GetComponent<Animator>();
        bookAnim.Play("open");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Hands")
        {
            _buttonAnimator.SetTrigger("ButtonPressed");
            bookAnim.Play("open");
            onButtonPressed?.Invoke();
            uiHeader.SetActive(true);
        }
        
    }
}
