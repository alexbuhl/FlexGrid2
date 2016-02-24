using UnityEngine;
using System.Collections;

public class CarControls : MonoBehaviour {

	public int speed; // Vitesse de mouvement
	public int angle; // angle de rotation
	public KeyCode left; // Touche clavier gauche
	public KeyCode right; // Touche droite
	public KeyCode up; // Touche haut
	public KeyCode backward; // Touche bas
	public WheelCollider wheelLR;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (up)) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}
		else if (Input.GetKey (backward)) {
			transform.Translate (Vector3.forward *  (- speed / 2) * Time.deltaTime);
		}
		//bool a = true;
		//while (a) {
		//	a = false;
			if (Input.GetKey (left)) {
				this.transform.Rotate (new Vector3 (0, -angle, 0));
		//		a = true;
			}
			if (Input.GetKey (right)) {
				this.transform.Rotate (new Vector3 (0, angle, 0));
		//		a = true;
		//	}
		}
	}
}
