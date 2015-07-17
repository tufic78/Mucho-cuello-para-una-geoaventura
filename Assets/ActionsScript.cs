using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class ActionsScript : MonoBehaviour {

	private Vector3 startingPosition;
	
	void Start() {
		//startingPosition = transform.localPosition;
		//SetGazedAt(false);
	}
	
	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.blue;
		
	}

	public void pressButtonSi()
	{
		Debug.Log("presionado si");
	}

	
	public void Reset() {
		transform.localPosition = startingPosition;
	}
	
	public void TeleportRandomly() {
		Vector3 direction = Random.onUnitSphere;
		direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
		float distance = 2 * Random.value + 1.5f;
		transform.localPosition = direction * distance;
	}

	void Update() {
	}
}