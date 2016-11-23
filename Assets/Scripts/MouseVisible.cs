using UnityEngine;
using System.Collections;

public class MouseVisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		Brick.brickCount = 0; //To restart the counter, everytime when you lose.
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
