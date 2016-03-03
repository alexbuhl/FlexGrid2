using UnityEngine;
using System.Collections;

public class Carfun : MonoBehaviour
{


    public int speed; // Vitesse de mouvement
    public int angle; // angle de rotation
    public KeyCode left; // Touche clavier gauche
    public KeyCode right; // Touche droite
    public KeyCode up; // Touche haut
    public KeyCode backward; // Touche bas
    public KeyCode derapage;
    private int reallyspeed;
    private int reallybackspeed;
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
            if (reallyspeed < speed)
            {
                reallyspeed += 1;
            }
            transform.Translate(Vector3.forward * reallyspeed * Time.deltaTime);
        }
        if (Input.GetKey(backward))
        {
            if (reallybackspeed < speed / 2)
            {
                reallybackspeed += 1;
            }
            transform.Translate(Vector3.forward * (-reallybackspeed) * Time.deltaTime);
        }
        if (Input.GetKey(left) && (Input.GetKey(up) || Input.GetKey(backward) || reallybackspeed > 1 || reallyspeed > 1) & !(Input.GetKey(derapage)))
        {
            this.transform.Rotate(new Vector3(0, -angle, 0));
        }
        if (Input.GetKey(right) && (Input.GetKey(up) || Input.GetKey(backward) || reallybackspeed > 1 || reallyspeed > 1) & !(Input.GetKey(derapage)))
        {
            this.transform.Rotate(new Vector3(0, angle, 0));
        }
    }
}
