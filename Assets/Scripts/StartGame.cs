using UnityEngine;

public class StartGame : MonoBehaviour {
	
	// Use this for initialization
	
	void Start () {
		//Invoke("LoadLevel", 3f);
	}
	
	public void LoadLevel() {
		Application.LoadLevel("CongaScene");
	}
	
}