using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {

	void Start () {
	}
	
	void Update () {
	}

	public void ReactToHit() {
		WanderingAI behavior = GetComponent<WanderingAI>();
		if (behavior != null) {
			behavior.SetAlive(false);
		}
		StartCoroutine(Die());
	}

	private IEnumerator Die() {
		this.transform.Rotate(-75, 0, 0);
		ScoreManager.score += 1;
		yield return new WaitForSeconds(1.5f);

		Destroy(this.gameObject);
	}
}
