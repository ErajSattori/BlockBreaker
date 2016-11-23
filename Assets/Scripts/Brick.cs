using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public static int brickCount = 0;
	public Sprite[] hitSprite;
	public AudioClip crack;
	private int timesHit;

	private ButtonManager levelManager;
	private bool isBreakable;

	// Use this for initialization
	void Start ()
	{
		isBreakable = (this.tag == "Breakable");
		//Keep track of breakable bricks.
		if (isBreakable) {
			brickCount++;
			print (brickCount);
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<ButtonManager>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D col)
	{
		AudioSource.PlayClipAtPoint (crack, transform.position);
		if (isBreakable) {
			HandleHits();
			Console.WriteLine("Made By Eraj Sattori");
		}
	}

	void HandleHits ()
	{
		timesHit++;
		int maxHits = hitSprite.Length + 1;
		if (timesHit >= maxHits) {
			brickCount--;
			levelManager.BricksDestroyed();
			Destroy (gameObject, 0.05f); // 0.05f is a fade time for brick to disappear
		} else {
			LoadSprite();

		}
	}


	void LoadSprite ()
	{
		int spriteIndex = timesHit - 1;
		if (hitSprite [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprite [spriteIndex];
		}
	}

}
