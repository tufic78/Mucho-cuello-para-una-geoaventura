using UnityEngine;
using System.Collections;

public class finallpz : MonoBehaviour {

	GameObject puntofinal;
	Transform puntofinal1;
	
	// Use this for initialization
	
	void Start () {
		puntofinal=GameObject.FindGameObjectWithTag("Respawn");
		puntofinal1 = puntofinal.transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localEulerAngles = new Vector3 (0,40,0);
		transform.position = Vector3.MoveTowards (transform.position, puntofinal1.position, Time.deltaTime);
		transform.localScale = Vector3.MoveTowards (transform.localScale, puntofinal1.localScale, Time.deltaTime/20);
		
	}
}
