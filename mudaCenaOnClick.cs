using UnityEngine;
using UnityEngine.SceneManagement;

public class mudaCenaOnClick : MonoBehaviour {
	
	public string novaCena;

	void OnMouseDown() {
		// Debug.Log ("Clicado!");
		SceneManager.LoadScene(novaCena, LoadSceneMode.Single  );
    }

}