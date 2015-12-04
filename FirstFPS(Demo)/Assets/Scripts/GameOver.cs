using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {
	public static int score;        // The player's health.
	Text text;                      // Reference to the Text component.

	void Awake() {
		text = GetComponent <Text> ();
		score = ScoreManager.score;
		text.text = "GAME OVER  :(\nYOUR SCORE: " + score;
	}

	void Update() {
		if (OverReturn.allowPress) {
			if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
				OverReturn.allowPress = false;
				Application.LoadLevel (0);
			}
			if (Input.GetKeyDown (KeyCode.Escape)) {
				OverReturn.allowPress = false;
				Application.Quit();
			}
		}
	}
}
