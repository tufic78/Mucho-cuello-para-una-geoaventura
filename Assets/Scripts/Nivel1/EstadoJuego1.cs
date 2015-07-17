using UnityEngine;
using System.Collections;

public class EstadoJuego1 : MonoBehaviour {

	float tiempo1;
	float tiempo2;
	float tiempo3;
	public GameObject particulas1;
	public GameObject llama;
	public GameObject charla1;
	public GameObject charla2;
	public GameObject charla3;
	public GameObject charla4;
	public GameObject charla5;
	public GameObject charla6;
	public GameObject botones;
	Animator anicharlas;
	public Animator anillama;
	public botonno noacepto;
	public botonsi siacepto;
	int conswitch = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tiempo1 += Time.deltaTime;

		if (tiempo1 > 1) {
			particulas1.SetActive (true);
		}
		if (tiempo1 > 5.5) {
			llama.SetActive (true);
		}
		if ((tiempo1 > 6.5) && (tiempo1 < 10.5)) {
			charla1.SetActive (true);
			anillama.SetBool ("hablando", true);
			anicharlas = charla1.GetComponent<Animator> ();
		}
		if ((tiempo1 > 10.5) && (tiempo1 < 11.5)) {

			anicharlas.SetBool ("fin", true);
			anillama.SetBool ("hablando", false);
		}
		if ((tiempo1 > 12.5) && (tiempo1 < 13.5)) {
			charla1.SetActive (false);

		}
		if ((tiempo1 > 13.5) && (tiempo1 < 18.5)) {
			charla2.SetActive (true);
			anillama.SetBool ("hablando", true);
			anicharlas = charla2.GetComponent<Animator> ();
		}
		if ((tiempo1 > 18.5) && (tiempo1 < 19.5)) {
			
			anicharlas.SetBool ("fin", true);
			anillama.SetBool ("hablando", false);
		}
		if ((tiempo1 > 20.5) && (tiempo1 < 21.5)) {
			charla2.SetActive (false);
		}
		if ((tiempo1 > 21.5) && (tiempo1 < 22.5)) {
			charla3.SetActive (false);
			anillama.SetBool ("hablando", true);
		}
		if ((tiempo1 > 22.5) && (tiempo1 < 26.5)) {
			charla3.SetActive (true);
			anicharlas = charla3.GetComponent<Animator> ();
		}

		if ((tiempo1 > 26.5) && (tiempo1 < 27.5)) {

			anillama.SetBool ("hablando", false);
			anicharlas.SetBool ("fin", true);

		}

		if ((tiempo1 > 28.5) && (tiempo1 < 29.5)) {
			charla3.SetActive (false);
			botones.SetActive (true);
		}

		if (siacepto.acepto == true) {

			tiempo2 += Time.deltaTime;

			if (tiempo2 > 3){
				AppState.Comienza();
				Application.LoadLevel ("Escena2");
			}

		}

		if (noacepto.nego == true) {
				

			conswitch = Random.Range(1,3);

			}

		if (noacepto.activadorno == true) {
			
			anillama.SetBool ("llamasi", false);
			anillama.SetBool ("llamano", true);
			
		}
		if (siacepto.activadorsi == true) {
			
			anillama.SetBool ("llamano", false);
			anillama.SetBool ("llamasi", true);
			
		}


		if (conswitch > 0) {
			tiempo3 += Time.deltaTime;
			if (conswitch == 1){
				noacepto.nego = false;
				anillama.SetBool ("llamano", false);
				if ((tiempo3 > 1) && (tiempo3 < 5)) {
					botones.SetActive(false);
					charla4.SetActive (true);
					anillama.SetBool ("hablando", true);
					anicharlas = charla4.GetComponent<Animator> ();
				}
				if ((tiempo3 > 5) && (tiempo3 < 6)) {
					
					anicharlas.SetBool ("fin", true);
					anillama.SetBool ("hablando", false);
				}
				if ((tiempo3 > 7) && (tiempo3 < 8)) {
					charla4.SetActive (false);
					botones.SetActive(true);
					noacepto.nego = false;
					tiempo3 = 0;
					conswitch = 0;

				}
			}

			if (conswitch == 2){
				noacepto.nego = false;
				anillama.SetBool ("llamano", false);
				if ((tiempo3 > 1) && (tiempo3 < 5)) {
					botones.SetActive(false);
					charla5.SetActive (true);
					anillama.SetBool ("hablando", true);
					anicharlas = charla5.GetComponent<Animator> ();
				}
				if ((tiempo3 > 5) && (tiempo3 < 6)) {
					
					anicharlas.SetBool ("fin", true);
					anillama.SetBool ("hablando", false);
				}
				if ((tiempo3 > 7) && (tiempo3 < 8)) {
					charla5.SetActive (false);
					botones.SetActive(true);
					noacepto.nego = false;
					tiempo3 = 0;
					conswitch = 0;
					
				}
			}

			if (conswitch == 3){

				anillama.SetBool ("llamano", false);
				if ((tiempo3 > 1) && (tiempo3 < 5)) {
					botones.SetActive(false);
					charla6.SetActive (true);
					anillama.SetBool ("hablando", true);
					anicharlas = charla6.GetComponent<Animator> ();
				}
				if ((tiempo3 > 5) && (tiempo3 < 6)) {
					
					anicharlas.SetBool ("fin", true);
					anillama.SetBool ("hablando", false);
				}
				if ((tiempo3 > 7) && (tiempo3 < 8)) {
					charla6.SetActive (false);
					botones.SetActive(true);
					noacepto.nego = false;
					tiempo3 = 0;
					conswitch = 0;
					
				}
			}

		}
			
	}
}