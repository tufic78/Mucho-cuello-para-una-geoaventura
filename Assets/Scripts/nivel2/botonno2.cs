﻿using UnityEngine;
using System.Collections;

public class botonno2 : MonoBehaviour {

	public bool activadorno;
	float time1;
	public GameObject barra1;
	public bool nego;
	
	
	// Use this for initialization
	void Start () {
		SetGazedAt(false);
		SetGazedEx(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (activadorno) {
			//Debug.Log (time1);
			time1 += Time.deltaTime;
			if (time1 > 0.5) {
				barra1.SetActive(true);
			}
			if (time1 > 2.5) {
				
				nego = true;
				barra1.SetActive(false);
				
			}
		}
		else {
			barra1.SetActive(false);
			time1 = 0;
			
		}
		
	}
	
	public void SetGazedAt(bool gazedAt) {
		
		activadorno = true;
		
		
	}
	
	public void SetGazedEx(bool gazedAt) {
		
		activadorno = false;
		
		
	}
}