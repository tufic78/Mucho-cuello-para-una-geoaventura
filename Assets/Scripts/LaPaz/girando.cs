using UnityEngine;
using System.Collections;

public class girando : MonoBehaviour {

	float contador;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		contador += 1;
		transform.localEulerAngles = new Vector3 (0,contador,0);

	}

}
