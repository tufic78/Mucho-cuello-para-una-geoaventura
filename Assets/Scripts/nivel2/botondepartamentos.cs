using UnityEngine;
using System.Collections;

public class botondepartamentos : MonoBehaviour {

	public bool activadordep;
	float time1;
	public GameObject barra;
	public string nomani;
	public Animator animacion;
	public bool confirmacion;
	// Use this for initialization
	void Start () {
	
		SetGazedAt(false);
		SetGazedEx(false);

	}
	
	// Update is called once per frame
	void Update () {
		if (confirmacion == false) {
			if (activadordep) {
				//Debug.Log (time1);
				time1 += Time.deltaTime;
				//if (time1 > 0.5) {
				//barra.SetActive(true);
				//}
				if (time1 > 1) {
				
					animacion.SetBool (nomani, true);
					if (time1 > 5) {

						confirmacion = true;

					}
				}
			} else {
				//barra.SetActive(false);
				animacion.SetBool (nomani, false);
				time1 = 0;
			
			}
		}

	}

	public void SetGazedAt(bool gazedAt) {
		
		activadordep = true;
		
		
	}
	
	public void SetGazedEx(bool gazedAt) {
		
		activadordep = false;
		
		
	}
}
