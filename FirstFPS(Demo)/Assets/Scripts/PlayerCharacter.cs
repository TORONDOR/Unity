using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour {
	private static int _health;

	void Start() {
		_health = 5;
		HealthManager.health = _health;
	}

	public static void SetHealth(int health) {
		_health = health;
	}

	public void Hurt(int damage) {
		_health -= damage;
		HealthManager.health = _health;
		Debug.Log("Health: " + _health);
		if (_health <= 0)
			Application.LoadLevel (2);
	}

	void Update() 
	{
		if (Input.GetKeyDown(KeyCode.Escape)) // this gives you access to the back button
			Application.LoadLevel(0); // this quits the game.
	}
}