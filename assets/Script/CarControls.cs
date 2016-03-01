﻿using UnityEngine;
using System.Collections;

public class CarControls : MonoBehaviour
{

    public int speed; // Vitesse de mouvement
    public int angle; // angle de rotation
    public KeyCode left; // Touche clavier gauche
    public KeyCode right; // Touche droite
    public KeyCode up; // Touche haut
    public KeyCode backward; // Touche bas
    private int reallyspeed;
    private int reallybackspeed;
    public Transform body;
    public Rigidbody rigid;
    public Transform wheelFRtransf;
    public Transform wheelRRtransf;
    public Transform wheelFLtransf;
    public Transform wheelRLtransf;
    public Transform etrierFRtransf;
    public Transform etrierRRtransf;
    public Transform etrierFLtransf;
    public Transform etrierRLtransf;
    public Transform volant;
    public int rotatespeed;
    public int rotatewheel;
    // Use this for initialization
    void Start()
    {
        reallyspeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            rigid.centerOfMass = new Vector3(0, -1, 0);
            if (reallyspeed < speed)
            {
                reallyspeed += 1;
            }
            transform.Translate(Vector3.forward * reallyspeed * Time.deltaTime);
        }
        else if (Input.GetKey(backward))
        {
            rigid.centerOfMass = new Vector3(0, 1, 0);
            if (reallybackspeed < speed / 2)
            {
                reallybackspeed += 1;
            }
            transform.Translate(Vector3.forward * (-reallybackspeed) * Time.deltaTime);
        }
        if (Input.GetKeyUp(up))
        {
            rigid.centerOfMass = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyUp(backward))
        {
            rigid.centerOfMass = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(left) && (Input.GetKey(up) || Input.GetKey(backward) || reallybackspeed > 1 || reallyspeed > 1))
        {
            this.transform.Rotate(new Vector3(0, -angle, 0));
        }
        if (Input.GetKey(right) && (Input.GetKey(up) || Input.GetKey(backward) || reallybackspeed > 1 || reallyspeed > 1))
        {
            this.transform.Rotate(new Vector3(0, angle, 0));
        }
        if (reallyspeed > 1 & !Input.GetKey(up))
        {
            reallyspeed -= 1;
            transform.Translate(Vector3.forward * reallyspeed * Time.deltaTime);
        }

        if (reallybackspeed > 1 & !Input.GetKey(backward))
        {
            reallybackspeed -= 1;
            transform.Translate(Vector3.forward * (-reallybackspeed) * Time.deltaTime);
        }
        if (Input.GetKey(up))
        {
            wheelFLtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelFRtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRRtransf.Rotate(-rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRLtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(backward))
        {
            wheelFLtransf.Rotate(- rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelFRtransf.Rotate(- rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRRtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRLtransf.Rotate(-rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(right))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y + rotatewheel, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y + rotatewheel, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y + rotatewheel, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y + rotatewheel, 0);
        }
        if (Input.GetKey(left))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y - rotatewheel, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y - rotatewheel, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y - rotatewheel, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y - rotatewheel, 0);
        }
        if (Input.GetKey(right) & Input.GetKey(backward))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y + rotatewheel, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y + rotatewheel, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y + rotatewheel, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y + rotatewheel, 0);
            wheelFLtransf.Rotate(- rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelFRtransf.Rotate(- rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRRtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRLtransf.Rotate(-rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            //volant.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, rotatespeed / 60 * 360 * Time.deltaTime);
        }
        if (Input.GetKey(left) & Input.GetKey(backward))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y - rotatewheel, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y - rotatewheel, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y - rotatewheel, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y - rotatewheel, 0);
            wheelFLtransf.Rotate(- rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelFRtransf.Rotate(- rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRRtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRLtransf.Rotate(-rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            //volant.Rotate(-rotatespeed / 60 * 360 * Time.deltaTime, 0, -rotatespeed / 60 * 360 * Time.deltaTime);
        }
        if (Input.GetKey(right) & Input.GetKey(up))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y + rotatewheel, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y + rotatewheel, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y + rotatewheel, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y + rotatewheel, 0);
            wheelFLtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelFRtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRRtransf.Rotate(-rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRLtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            //volant.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, rotatespeed / 60 * 360 * Time.deltaTime);
        }
        if (Input.GetKey(left) & Input.GetKey(up))
        {
            wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y - rotatewheel, 0);
            wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y - rotatewheel, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y - rotatewheel, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y - rotatewheel, 0);
            wheelFLtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelFRtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRRtransf.Rotate(-rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            wheelRLtransf.Rotate(rotatespeed / 60 * 360 * Time.deltaTime, 0, 0);
            //volant.Rotate(-rotatespeed / 60 * 360 * Time.deltaTime, 0, -rotatespeed / 60 * 360 * Time.deltaTime);

        }
        /*
        if (!Input.GetKey(right) & !Input.GetKey(left) & wheelFLtransf.localEulerAngles.y != 0)
        {
            if (wheelFLtransf.localEulerAngles.y > 0)
            {
                wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y - 1, 0);
                wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y - 1, 0);
            }
            if (wheelFLtransf.localEulerAngles.y < 0)
            {
                wheelFLtransf.localEulerAngles = new Vector3(0, wheelFLtransf.localEulerAngles.y + 1, 0);
                wheelFRtransf.localEulerAngles = new Vector3(0, wheelFRtransf.localEulerAngles.y + 1, 0);
            }
        }*/
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
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y * 3 / 4, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y * 3 / 4, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y / 2, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y / 2, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y / 4, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y / 4, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, etrierFRtransf.localEulerAngles.y / 8, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, etrierFLtransf.localEulerAngles.y / 8, 0);
            etrierFRtransf.localEulerAngles = new Vector3(0, 0, 0);
            etrierFLtransf.localEulerAngles = new Vector3(0, 0, 0);
            //volant.localEulerAngles = new Vector3(0, volant.eulerAngles.y, 0);
        }
    }
}
