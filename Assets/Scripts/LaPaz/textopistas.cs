using UnityEngine;
using System.Collections;

public class textopistas : MonoBehaviour {


	public TextMesh texto;
	public detectarobj texto1;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		texto.text = texto1.pista;
	}
}