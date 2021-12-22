using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonCloseBook : MonoBehaviour
{
	public Button bookButton;
	public Animator bookAnim;

	void Start()
	{
		Button btn = bookButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		Debug.Log("book hallo");
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		bookAnim.Play("close");
	}
}