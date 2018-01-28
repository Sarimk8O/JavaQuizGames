using UnityEngine;
using System.Collections;

[System.Serializable]
public class RoundData 
{

	public string name;
	public int timeLimitInSecond;
	public int pointsAddedForCorrectAnswer;
	public QuestionData[] questions;
}
