using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Datacontroller : MonoBehaviour {

	public RoundData[] allRoundData;
	private PlayerProgress playerProgress;

	void Start()
	{
		DontDestroyOnLoad (gameObject);
		LoadPlayerProgress ();
	
		SceneManager.LoadScene ("main menu");
	}


	public RoundData getCurrentRoundData()
	{
		return allRoundData [0];
	
	}
	public RoundData getCurrentRoundData1()
	{
		return allRoundData [1];
	}

	public RoundData getCurrentRoundData2()
	{
		return allRoundData [2];
	}
	public RoundData getCurrentRoundData3()
	{
		return allRoundData [3];
	}

	public RoundData getCurrentRoundData4()
	{
		return allRoundData [4];
	}

	public RoundData getCurrentRoundData5()
	{
		return allRoundData [5];
		
	}

	public RoundData getCurrentRoundData6()
	{
		return allRoundData [6];
	}

	public RoundData getCurrentRoundData7()
	{
		return allRoundData [7];
	}
	public RoundData getCurrentRoundData8()
	{
		return allRoundData [8];
	}
	public RoundData getCurrentRoundData9()
	{
		return allRoundData [9];
	}


	public void SubmitNewPlayerScore(int newScore)
	{
		if (newScore > playerProgress.highestScore) 
		{
			playerProgress.highestScore = newScore;
			SavePlayerProgress ();
		}
	}

	public int GetHighestPlayerScore()
	{
		return playerProgress.highestScore;
	}

	private void LoadPlayerProgress()
	{
		
		playerProgress = new PlayerProgress ();

		if(PlayerPrefs.HasKey("HighestScore"))
			{
			playerProgress.highestScore = PlayerPrefs.GetInt ("highestScore");
			}
	}

	private void SavePlayerProgress()
	{
		PlayerPrefs.SetInt ("highestScore", playerProgress.highestScore);

		
	}

















	void Update(){
	
	
	}
}
