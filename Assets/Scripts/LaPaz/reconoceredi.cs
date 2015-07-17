using UnityEngine;
using System.Collections;

public class reconoceredi : MonoBehaviour {

	public bool activadoredi;
	// Use this for initialization
	void Start () {
		SetGazedAt(false);
		SetGazedEx(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetGazedAt(bool gazedAt) {
		
		activadoredi = true;
		
		
	}
	
	public void SetGazedEx(bool gazedAt) {
		
		activadoredi = false;
		
		
	}
}
