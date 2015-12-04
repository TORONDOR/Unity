using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;
	private int bonusClick = 0;
	public static bool bonusHealth = false; 
	private string cheat ="";
	

	void Start () {
		bonusHealth = false;
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = true;
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}

	public void ExitPress() {
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress() {
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel() {
		cheat = "";
		Application.LoadLevel (1);
	}

	public void ExitGame () {
		Application.Quit ();
	}

	void BonusMode() {
		if (cheat.Length > 5)
			cheat = "";
		if (Input.GetKeyDown("b"))
			cheat += "b";
		if (Input.GetKeyDown("o"))
			cheat += "o";
		if (Input.GetKeyDown("n"))
			cheat += "n";
		if (Input.GetKeyDown("u"))
			cheat += "u";
		if (Input.GetKeyDown("s"))
			cheat += "s";
		if (Input.GetKeyDown("`"))
			cheat = "";
		if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.KeypadEnter)) {
			if (cheat == "bonus") {
				cheat = "";
				bonusHealth = true;
			}
			else {
				cheat = "";
			}
		}
	}

	void Update () {
		BonusMode ();
		Debug.Log (cheat);
	}
}
