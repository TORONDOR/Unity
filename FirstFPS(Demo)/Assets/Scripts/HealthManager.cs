using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {
	public static int health;        // The player's health.
	Text text;                      // Reference to the Text component.

	void Awake() {
		// Set up the reference.
		text = GetComponent <Text> ();
		health = 5;
	}

	void Start() {
		if (!MenuScript.bonusHealth) {
			PlayerCharacter.SetHealth (5);
			health = 5;
		} else {
			PlayerCharacter.SetHealth (666);
			health = 666;
		}
	}

	void Update() {
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Health: " + health;
	}
}
