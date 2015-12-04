using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OverReturn : MonoBehaviour {
	public static bool allowPress = false;
	Text text; 

	void Start() {
		text = GetComponent <Text> ();
		Invoke ("ReturnToMenu", 2);
	}

	void ReturnToMenu() {
		text.text = "Press ENTER to return to menu...\n" + 
					"Press ESC to exit from the game...";
		allowPress = true;
	}
}
