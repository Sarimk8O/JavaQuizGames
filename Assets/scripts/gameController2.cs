using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class gameController2 : MonoBehaviour {

	public Text questiontext;
	public Text ScoreDiplayText;
	public GameObject questionPannel;
	public GameObject roundEndPannel;

	private Datacontroller dataController;
	private RoundData currentRoundData;
	private QuestionData[] questionpool;
	public Text TimeRemainginDisplayText;

	private bool isRoundActive;
	private float timeRemaining;
	private int questionIndex;
	private int PlayerScore;

	private List <GameObject> answerButtonGameObjects = new List<GameObject> ();

	public simpleObjectPool answerButtonObjectPool;

	public Transform answerButtonParent;
	// Use this for initialization
	void Start () {

		dataController = FindObjectOfType<Datacontroller> ();
		currentRoundData = dataController.getCurrentRoundData2 ();

		questionpool = currentRoundData.questions;
		timeRemaining = currentRoundData.timeLimitInSecond;
		UpdateTimeRemainingDisplay ();

		PlayerScore = 0;
		questionIndex = 0;
		ShowQuestion ();

		isRoundActive = true;


	}

	private void ShowQuestion()
	{

		RemoveAnswerButton ();
		QuestionData questionData = questionpool [questionIndex];
		questiontext.text = questionData.questiontext;

		for (int i = 0; i < questionData.answers.Length; i++) 
		{
			GameObject answerButtonGameObject = answerButtonObjectPool.GetObject ();
			answerButtonGameObjects.Add (answerButtonGameObject);
			answerButtonGameObject.transform.SetParent (answerButtonParent);

			AnswerButton answerButton=answerButtonGameObject.GetComponent<AnswerButton>();
			answerButton.Setup (questionData.answers [i]);
		}

	}

	private void RemoveAnswerButton(){
		while (answerButtonGameObjects.Count > 0) 
		{
			answerButtonObjectPool.ReturnObject (answerButtonGameObjects [0]);
			answerButtonGameObjects.RemoveAt (0);
		}
	}

	public void AnswerButtonClicked(bool isCorrect)
	{

		if (isCorrect) {

			PlayerScore += currentRoundData.pointsAddedForCorrectAnswer;
			ScoreDiplayText.text = "Score: " + PlayerScore.ToString ();
		}
		if (!isCorrect) 
		{
			PlayerScore -= currentRoundData.pointsAddedForCorrectAnswer;
			ScoreDiplayText.text = "Score: " + PlayerScore.ToString ();

		}

		if (questionpool.Length > questionIndex + 1) {
			questionIndex++;
			ShowQuestion ();

		} else 
		{

			EndRound ();

		}

	}


	public void EndRound()
	{
		isRoundActive = false;
		//dataController.SubmitNewPlayerScore (PlayerScore);
		//ScoreDiplayText.text = dataController.GetHighestPlayerScore ().ToString ();

		questionPannel.SetActive (false);
		roundEndPannel.SetActive (true);

	}


	private void UpdateTimeRemainingDisplay()
	{
		TimeRemainginDisplayText.text = "Time: " + Mathf.Round (timeRemaining).ToString ();

	}
	// Update is called once per frame
	void Update () 
	{
		if (isRoundActive) 
		{
			timeRemaining -= Time.deltaTime;
			UpdateTimeRemainingDisplay ();

			if (timeRemaining <= 0f) 
			{
				EndRound ();

			}
		}

	}

	public void ReturnToMenu(){

		SceneManager.LoadScene ("menu scene");
	}
}

