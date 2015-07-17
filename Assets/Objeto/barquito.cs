using UnityEngine;
using System.Collections;

public class barquito : MonoBehaviour {

	public GameObject contenedor;
	public Transform contenedorfinal;

	private Vector3 v = new Vector3(-12,-4,-5);
	// Use this for initialization
	void Start () {
		Instantiate (contenedor,v,this.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
