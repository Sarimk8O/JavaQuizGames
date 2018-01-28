using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour {

	public Text answerText;
	private AnswerScript answerscript;
	private GameController gameController;
	private gameController1 GameController1;
	private gameController2 GameController2;
	private gamecontroller3 gameController3;
	private gameController4 gamecontroller4;
	private gameController5 gamecontroller5;
	private gameController6 gamecontroller6;
	private gameController7 gamecontroller7;
	private gameController8 gamecontroller8;
	private gameController9 gamecontroller9;

	// Use this for initialization
	void Start () 
	{
		gameController = FindObjectOfType<GameController> ();	
		GameController1 = FindObjectOfType<gameController1> ();
		GameController2 = FindObjectOfType<gameController2>();
		gameController3 = FindObjectOfType<gamecontroller3> ();
		gamecontroller4 = FindObjectOfType<gameController4> ();
		gamecontroller5 = FindObjectOfType<gameController5> ();
		gamecontroller6 = FindObjectOfType<gameController6> ();
		gamecontroller7 = FindObjectOfType<gameController7> ();
		gamecontroller8 = FindObjectOfType<gameController8> ();
		gamecontroller9 = FindObjectOfType<gameController9> ();

	}

	public void Setup (AnswerScript data){
	
		answerscript = data;
		answerText.text = answerscript.answerText;
	}
	
	public void HandleClicked(){
	
		gameController.AnswerButtonClicked (answerscript.iscorrect);
	}

	public void HandleClicked1()
	{
		GameController1.AnswerButtonClicked (answerscript.iscorrect);
	
	}
	public void HandleClicked2()
	{
		GameController2.AnswerButtonClicked (answerscript.iscorrect);
		
	}
	public void HandleClicked3 ()
	{
		gameController3.AnswerButtonClicked (answerscript.iscorrect);
	}

	public void HandleClicked4()
	{
		gamecontroller4.AnswerButtonClicked (answerscript.iscorrect);
	}

	public void HandleClicked5()
	{
		gamecontroller5.AnswerButtonClicked (answerscript.iscorrect);

	}

	public void HandleClicked6()
	{
		gamecontroller6.AnswerButtonClicked (answerscript.iscorrect);
	}

	public void HandleClicked7()
	{
		gamecontroller7.AnswerButtonClicked (answerscript.iscorrect);
	}
	public void HandleClicked8()
	{
		gamecontroller8.AnswerButtonClicked (answerscript.iscorrect);
	}
	public void HandleClicked9()
	{
		gamecontroller9.AnswerButtonClicked (answerscript.iscorrect);
	}
}
