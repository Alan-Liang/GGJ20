using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateOther : MonoBehaviour {

	GameObject prefab;
	float speed = 4.0f;
	// Use this for initialization
	void Start () {
		this.prefab = Instantiate((GameObject) Resources.Load("Other"));
		float theta = Random.Range(1f, 360f);
		this.prefab.transform.position = new Vector3(15f*(float)System.Math.Cos(System.Math.PI/360f*theta), 0.5f, 15f*(float)System.Math.Sin(System.Math.PI/360f*theta));
	}
	
	// Update is called once per frame
	void Update () {
		float theta = Random.Range(1f, 360f);
		Vector3 baseT = new Vector3(1f*(float)System.Math.Cos(System.Math.PI/360f*theta), 0f, 1f*(float)System.Math.Sin(System.Math.PI/360f*theta))*this.speed;
		this.prefab.transform.Translate(baseT * Time.deltaTime);
	}
}
