using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Paddle : MonoBehaviour {
	public static bool autoPlay = false;
	public Ball ball;
	// Use this for initialization
	void Start ()
	{
		ball = GameObject.FindObjectOfType<Ball> ();
		if (Input.GetKeyDown (KeyCode.Q)) {
			Application.LoadLevel("StartMenu");
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay();
		}
	}



	void MoveWithMouse ()
	{
		Vector2 paddlePos = new Vector3 (0.712f, this.transform.position.y);
		float mouseXPosInBlock = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp (mouseXPosInBlock, 0.712f, 15.288f);
		this.transform.position = paddlePos;
	}

	//Bot script
	void AutoPlay()
	{
		Vector2 paddlePos = new Vector3 (0.712f, this.transform.position.y);
		Vector2 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp (ballPos.x, 0.712f, 15.288f);
		this.transform.position = paddlePos;
	}

}
