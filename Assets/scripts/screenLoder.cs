using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class screenLoder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void menuScene()
	{
		SceneManager.LoadScene ("menu scene");
		
	}

	public void applicationExit()
	{
		Application.Quit ();
	}

	public void About()
	{
		SceneManager.LoadScene ("About");
	}

}
