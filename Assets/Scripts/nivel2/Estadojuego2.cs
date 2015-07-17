using UnityEngine;
using System.Collections;

public class Estadojuego2 : MonoBehaviour {

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
	public GameObject mapamundi;
	public GameObject mapabolivia;
	Animator anicharlas;
	public Animator anillama;
	public botonno2 noacepto;
	public botonsi2 siacepto;
	int conswitch = 0;
	public botondepartamentos departamento1;
	public botondepartamentos departamento2;
	public botondepartamentos departamento3;
	public botondepartamentos departamento4;
	public botondepartamentos departamento5;
	public botondepartamentos departamento6;
	public botondepartamentos departamento7;
	public botondepartamentos departamento8;
	public botondepartamentos departamento9;
	public GameObject particulas2;
	public GameObject particulas3;
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
			mapamundi.SetActive (true);
			anicharlas = charla4.GetComponent<Animator> ();
		}

		if ((tiempo1 > 39) && (tiempo1 < 43)) {

			anillama.SetBool ("hablando", true);
			charla4.SetActive (true);
		}

		if ((tiempo1 > 43) && (tiempo1 < 44)) {
			
			anillama.SetBool ("hablando", false);
			anicharlas.SetBool ("fin", true);
			
		}

		if ((tiempo1 > 44) && (tiempo1 < 45)) {
			charla4.SetActive (false);
			anicharlas = charla5.GetComponent<Animator> ();
		}
		if ((tiempo1 > 46) && (tiempo1 < 50)) {
			
			anillama.SetBool ("hablando", true);
			charla5.SetActive (true);
		}
		
		if ((tiempo1 > 50) && (tiempo1 < 51)) {
			
			anillama.SetBool ("hablando", false);
			anicharlas.SetBool ("fin", true);
			
		}
		
		if ((tiempo1 > 51) && (tiempo1 < 52)) {
			charla5.SetActive (false);
			mapabolivia.SetActive(true);
			anicharlas = charla6.GetComponent<Animator> ();
		}

		if((departamento1.confirmacion == true) || (departamento2.confirmacion == true) || (departamento3.confirmacion == true) 
		   || (departamento4.confirmacion == true) || (departamento5.confirmacion == true) || (departamento6.confirmacion == true)
		   || (departamento7.confirmacion == true) || (departamento8.confirmacion == true) || (departamento9.confirmacion == true))
		{
			tiempo2 += Time.deltaTime;
			if ((tiempo2 > 3) && (tiempo2 < 7)) {
				
				anillama.SetBool ("hablando", true);
				charla6.SetActive (true);
				botones.SetActive(true);
			}
			
			if ((tiempo2 > 7) && (tiempo2 < 8)) {
				
				anillama.SetBool ("hablando", false);
								
			}
			

		}
		
		if (siacepto.acepto == true) {
			
			tiempo2 += Time.deltaTime;
			
			if (tiempo2 > 3){

				particulas2.SetActive(true);

				if (tiempo2 > 6){
					if(departamento1.confirmacion == true){
						AppState.Viajar(8);
						Application.LoadLevel ("EscenaPando");
					}
					if(departamento2.confirmacion == true){
						AppState.Viajar(0);
						Application.LoadLevel ("EscenaLaPaz");
					}
					if(departamento3.confirmacion == true){
						AppState.Viajar(7);
						Application.LoadLevel ("EscenaBeni");
					}
					if(departamento4.confirmacion == true){
						AppState.Viajar(1);
						Application.LoadLevel ("EscenaOruro");
					}
					if(departamento5.confirmacion == true){
						AppState.Viajar(5);
						Application.LoadLevel ("EscenaCochabamba");
					}
					if(departamento6.confirmacion == true){
						AppState.Viajar(2);
						Application.LoadLevel ("EscenaPotosi");
					}
					if(departamento7.confirmacion == true){
						AppState.Viajar(4);
						Application.LoadLevel ("EscenaChuquisaca");
					}
					if(departamento8.confirmacion == true){
						AppState.Viajar(6);
						Application.LoadLevel ("EscenaSantaCruz");
					}
					if(departamento9.confirmacion == true){
						AppState.Viajar(3);
						Application.LoadLevel ("EscenaTarija");
					}
				}
			}
			
		}

		if (noacepto.nego == true) {
			
			departamento1.confirmacion = false;
			departamento2.confirmacion = false;
			departamento3.confirmacion = false;
			departamento4.confirmacion = false;
			departamento5.confirmacion = false;
			departamento6.confirmacion = false;
			departamento7.confirmacion = false;
			departamento8.confirmacion = false;
			departamento9.confirmacion = false;
			
		}

		if ((departamento2.activadordep == true) || (departamento2.confirmacion == true)) {

			tiempo3 += Time.deltaTime;

			if (tiempo3 > 1) {
			
				particulas3.SetActive (true);

			}


		} else {
		
			particulas3.SetActive (false);
			tiempo3 = 0;
		
		}
		/*if (noacepto.nego == true) {
			
			
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
*/
	}
}