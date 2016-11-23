using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonManager : MonoBehaviour {
	public Text text;
	public void LoadLevel(string name){
		Debug.Log("New Level load: " + name);
		Application.LoadLevel(name);
	}
	public void QuitRequest ()
	{
		Debug.Log ("Quit Requested ");
		Application.Quit ();
	}



	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void AutoPlayOn ()
	{
		Paddle.autoPlay = true;
	}

	public void AutoPlayOff ()
	{
		Paddle.autoPlay = false;
	}

	public void BricksDestroyed ()
	{
		if (Brick.brickCount <= 0) {
			Debug.Log("Next Level Loading...");
			LoadNextLevel();
		}
	}
}
