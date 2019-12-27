using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodaObjecto : MonoBehaviour {
	[Range(-20.0f, 20.0F)]
	public float meuAnguloX = 0.0f;
	[Range(-20.0f, 20.0F)]
	public float meuAnguloY = 0.0f;
	[Range(-20.0f, 20.0F)]
	public float meuAnguloZ = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(meuAnguloX, meuAnguloY, meuAnguloZ);
	}
}
