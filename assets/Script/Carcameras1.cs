using UnityEngine;
using System.Collections;

public class Carcameras1 : MonoBehaviour {

    // Use this for initialization
    public Camera camera;
    public KeyCode cameragauche;
    public KeyCode cameradroite;
    public KeyCode camerapilote;
    public KeyCode cameraarriere;
    public int décalagecoté;
    public int decalageavant;
    public int decalagehauteur;
    private bool cameradroit = false;
    private bool cameragauch = false;
    private bool camerapilot = false;
    private bool cameraarrier = false;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(cameragauche) & cameragauch)
        {
            cameragauch = false;
            camera.transform.Translate(Vector3.right * décalagecoté * Time.deltaTime);
        }
        if (Input.GetKeyDown(cameradroite) & cameradroit)
        {
            cameradroit = false;
            camera.transform.Translate(Vector3.left * décalagecoté * Time.deltaTime);
        }
        if (Input.GetKeyDown(camerapilote) & camerapilot)
        {
            camerapilot = false;
            camera.transform.Translate(Vector3.forward * décalagecoté * Time.deltaTime);
        }*/
        if (Input.GetKeyDown(cameragauche))
        {
            cameragauch = true;
            camera.transform.Translate(Vector3.left * décalagecoté * Time.deltaTime);
        }
        if (Input.GetKeyDown(cameradroite))
        {
            cameradroit = true;
            camera.transform.Translate(Vector3.right * décalagecoté * Time.deltaTime);
        }
        if (Input.GetKeyDown(camerapilote))
        {
            camerapilot = true;
            camera.transform.Translate(Vector3.forward * decalageavant * Time.deltaTime);
            camera.transform.Translate(Vector3.down * decalagehauteur * Time.deltaTime);
        }
        if (Input.GetKeyDown(cameraarriere))
        {
            camerapilot = true;
            camera.transform.Translate(Vector3.forward * (- decalageavant) * Time.deltaTime);
            camera.transform.Translate(Vector3.up * decalagehauteur * Time.deltaTime);
        }
    }
}
