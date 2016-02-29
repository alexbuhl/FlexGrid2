using UnityEngine;
using System.Collections;

public class CarCamera : MonoBehaviour {

    public Transform car;
    public float distance;
    public float height;
    public float rotationDamping;
    public float heightDamping;
    public float zoomRatio;
    public float DefaultFOV;
    private Vector3 rotatioVector;
	// Use this for initialization
	void Start () {
        var wantedAngle = car.eulerAngles.y;
        var wantedHeight = car.position.y;
        var myAngle = transform.eulerAngles.y;
        var myHeight = transform.position.y;
        myAngle = Mathf.LerpAngle(myAngle, wantedAngle, rotationDamping * Time.deltaTime);
        myHeight = Mathf.LerpAngle(myHeight, wantedHeight, heightDamping * Time.deltaTime);
        var currentRotation = Quaternion.Euler(0, myAngle, 0);
        transform.position = car.position;
        transform.position -= currentRotation * Vector3.forward * distance;
        transform.position.Set(transform.position.x, myHeight, transform.position.z);
        transform.LookAt(car);
	}
	
	// Update is called once per frame
	void Update () {
        var localVelocity = car.InverseTransformDirection(car.transform.position);
        if (localVelocity.z < -0.5)
        {
            rotatioVector.y = car.eulerAngles.y + 180;
        }
        else
        {
            rotatioVector.y = car.eulerAngles.y;
        }
        var acc = car.transform.position.magnitude;
        Camera.main.fieldOfView = DefaultFOV + acc * zoomRatio;
	}
}
