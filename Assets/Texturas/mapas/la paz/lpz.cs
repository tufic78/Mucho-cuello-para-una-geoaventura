using UnityEngine;
using System.Collections;

public class lpz : MonoBehaviour {
	public GameObject contenedor;
	public Transform contenedorfinal;
	private Vector3 v = new Vector3(-9,1,-1);
	// Use this for initialization
	void Start () {
		Instantiate (contenedor,v,this.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
