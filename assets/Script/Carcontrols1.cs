using UnityEngine;
using System.Collections;

public class Carcontrols1 : MonoBehaviour
{

    public Transform body;
    public Rigidbody rigid;
    public Transform wheelFRtransf;
    public Transform wheelRRtransf;
    public Transform wheelFLtransf;
    public Transform wheelRLtransf;
    public KeyCode left; // Touche clavier gauche
    public KeyCode right; // Touche droite
    public KeyCode up; // Touche haut
    public KeyCode backward; // Touche bas
    public int rotatespeed;
    public int rotatewheel;

    // Use this for initialization
    void Start()
    {
        rigid.centerOfMass = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up) || Input.GetKey(right) || Input.GetKey(left) || Input.GetKey(backward))
        {
            wheelFLtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelFRtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRRtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRLtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(right))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y + rotatewheel, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y + rotatewheel, 0);
        }
        if (Input.GetKey(left))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y - rotatewheel, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y - rotatewheel, 0);
        }
        if (Input.GetKeyUp(left) || Input.GetKeyUp(right))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y * 3 / 4, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y * 3 / 4, 0);
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y / 2, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y / 2, 0);
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y / 4, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y / 4, 0);
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y / 8, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y / 8, 0);
            wheelFRtransf.localEulerAngles = new Vector3(0, 0, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, 0, 0);
        }
        /*
        if (Input.GetKey(up))
            if (wheelFLtransf.localEulerAngles.y > body.localEulerAngles.y)
            {
                wheelFRtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y - rotatewheel, 0);
                wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y - rotatewheel, 0);
            }
            else if (wheelFLtransf.localEulerAngles.y < body.localEulerAngles.y)
            {
                wheelFRtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y + rotatewheel, 0);
                wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y + rotatewheel, 0);
            }
            */
    }
}