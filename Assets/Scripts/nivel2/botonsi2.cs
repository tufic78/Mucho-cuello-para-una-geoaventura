using UnityEngine;
using System.Collections;

public class botonsi2 : MonoBehaviour {

	public bool activadorsi;
	float time1;
	public GameObject barra1;
	public bool acepto;
	
	
	// Use this for initialization
	void Start () {
		SetGazedAt(false);
		SetGazedEx(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (activadorsi == true) {
			//Debug.Log (time1);
			time1 += Time.deltaTime;
			if ((time1 > 0.5)&&(time1 < 2.5)) {
				barra1.SetActive(true);
			}
			if (time1 > 2.5) {
				
				acepto = true;
				barra1.SetActive(false);
				
			}
		}
		
		else {
			barra1.SetActive(false);
			time1 = 0;
			
		}
		
	}
	
	public void SetGazedAt(bool gazedAt) {
		
		activadorsi = true;
		
		
	}
	
	public void SetGazedEx(bool gazedAt) {
		
		activadorsi = false;
		
		
	}
}