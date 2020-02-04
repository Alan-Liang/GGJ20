using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour {

	float startTime = -1f;
	bool locked = false;
	public UnityEngine.UI.Text label;
	// Use this for initialization
	void Start () {
		this.label.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.locked) return;
		float dist = Vector3.Distance(transform.position, new Vector3(0, 0, 0));
		if (dist < 5f) {
			if (startTime == -1f) {
				startTime = Time.time;
			} else if (Time.time - startTime > 5.0f) {
				this.label.text = "You Won!";
				this.label.enabled = true;
				this.locked = true;
			}
		} else if (dist > 50f) {
			this.label.text = "You Lost...";
			this.label.enabled = true;
			this.locked = true;
		}
	}
}
