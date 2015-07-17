using UnityEngine;
using System.Collections;

public class EstadoNivelLP : MonoBehaviour {
	public GameObject obj1;
	public GameObject obj2;
	public GameObject obj3;
	public GameObject obj4;
	public GameObject obj5;
	public Transform posicion1;
	public Transform posicion2;
	public Transform posicion3;
	public detectarobj detect;
	// Use this for initialization
	void Start () {
		AppState.Comienza ();

		int[] lugares = AppState.LugaresInformacion ();
		Vector3[] posiciones = { posicion1.transform.position, posicion2.transform.position, posicion3.transform.position };
		int actpos = 0;
		for (int i=0; i<3; i++) {
			if (lugares[i] == 0)
			{
				// mostrar terminal
				Instantiate(obj1, posiciones[actpos++], this.transform.rotation);
			}
			else if (lugares[i] == 1){
				Instantiate(obj2, posiciones[actpos++], this.transform.rotation);
			}
			else if (lugares[i] == 2){
				Instantiate(obj3, posiciones[actpos++], this.transform.rotation);
			}
			else if (lugares[i] == 3){
				Instantiate(obj4, posiciones[actpos++], this.transform.rotation);
			}
			else if (lugares[i] == 4){
				Instantiate(obj5, posiciones[actpos++], this.transform.rotation);
			}


		}

		detect.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
