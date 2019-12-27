using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudaCena : MonoBehaviour {

	public string cenaAgora = "Cena01";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		Application.LoadLevel(cenaAgora);
	}


}
