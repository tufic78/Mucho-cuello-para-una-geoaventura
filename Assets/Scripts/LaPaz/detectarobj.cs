using UnityEngine;
using System.Collections;

public class detectarobj : MonoBehaviour {

	GameObject obj1;
	GameObject obj2;
	GameObject obj3;
	reconoceredi edi1;
	reconoceredi edi2;
	reconoceredi edi3;
	public string pista;



	// Use this for initialization
	void Start () {
		int[] lugares = AppState.LugaresActuales ();
		Debug.Log (lugares == null?"nulo":"no nulo");
		GameObject[] objs = { obj1, obj2, obj3 };
		for (int i=0; i<3; i++) {
			string t = "Obj"+(lugares[i]+1);
			Debug.Log(t);
			objs[i] = GameObject.FindWithTag (t);

		}
		obj1 = objs [0];
		obj2 = objs [1];
		obj3 = objs [2];
		//if (obj1==null) Debug.Log("nulo obj1");
			

		edi1 = obj1.GetComponent<reconoceredi> ();
		edi2 = obj2.GetComponent<reconoceredi> ();
		edi3 = obj3.GetComponent<reconoceredi> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (edi1.activadoredi == true) {
			//Debug.Log ("choque 1 " + obj1.gameObject.tag.Substring(obj1.gameObject.tag.Length-1, 1));
			//Debug.Log (AppState.ObtenerPista( int.Parse(obj1.gameObject.tag.Substring(obj1.gameObject.tag.Length-1, 1)) - 1 ));
			pista = AppState.ObtenerPista( int.Parse(obj1.gameObject.tag.Substring(obj1.gameObject.tag.Length-1, 1)) - 1 );
			pista = pista.Substring(0,22)+"\n"+pista.Substring(22,pista.Length-22);
		} 
		if (edi2.activadoredi == true) {
			Debug.Log ("choque 2 "+ obj2.gameObject.tag);
			pista = AppState.ObtenerPista( int.Parse(obj1.gameObject.tag.Substring(obj2.gameObject.tag.Length-1, 1)) - 1 );
		} 
		if (edi3.activadoredi == true) {
			Debug.Log ("choque 3 "+ obj3.gameObject.tag);
			pista = AppState.ObtenerPista( int.Parse(obj1.gameObject.tag.Substring(obj3.gameObject.tag.Length-1, 1)) - 1 );
		} 
	}
}







