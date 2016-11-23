using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	private ButtonManager levelManager;
	
	void OnTriggerEnter2D (Collider2D collider){
		levelManager = GameObject.FindObjectOfType<ButtonManager>();
		levelManager.LoadLevel("LooseScreen");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}

