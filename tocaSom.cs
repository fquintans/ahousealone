using UnityEngine;
using System.Collections;

public class tocaSom : MonoBehaviour {

	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown() {
		if( ! audio.isPlaying ) {
			audio.Play();
		}
    }
	
}
