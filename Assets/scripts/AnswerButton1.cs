using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton1 : MonoBehaviour {

	public Text answerText;
	private AnswerScript answerscript;
	private gameController1 gameController;

	// Use this for initialization
	void Start () 
	{
		gameController = FindObjectOfType<gameController1> ();	
	}

	public void Setup (AnswerScript data){

		answerscript = data;
		answerText.text = answerscript.answerText;
	}

	public void HandleClicked(){

		gameController.AnswerButtonClicked (answerscript.iscorrect);
	}
}