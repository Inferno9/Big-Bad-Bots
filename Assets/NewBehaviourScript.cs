using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject fire;
    public GameObject missile;
    public GameObject laser;
    public float playerx=0.0f;
    public float playery;
    private float playerz;
    public bool onplat;

    private int fly=20;
    private float timer=5.0f;
    private bool swich = false;
    private float time;
    private bool fired;

    private bool burn;
    private float tme=0.5f;

    private bool brn;
    private float tm = 5;


    private Vector3 missle;
    private Quaternion rotate = new Quaternion();

    // Use this for initialization
    void Start () {

    }
   


        // Update is called once per frame
        void Update () {
        playerx = (transform.position.x);
        playery = (transform.position.y);
        missle = new Vector2(playerx, playery);




        if (fly<2) {
            if (Input.GetKey(KeyCode.W))
            {

                GetComponent<Rigidbody2D>().AddForce(Vector3.up * 500 * Time.deltaTime);
                fly += 1;
                onplat = true;
            }
           

        }

        if (timer > 0)
        {

            timer -= Time.deltaTime;
        }
        if (timer < 1 && swich==true)
        {
            fly = 0;
            swich = false;
        }



        if (onplat==true) {
            if (Input.GetKey(KeyCode.D))
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.right * 25 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.left * 25 * Time.deltaTime);
            }



        }
        if (onplat == false)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += transform.right * 7 * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= transform.right * 7 * Time.deltaTime;
            }
        }


        //cooldown for weapons
        //missile
        if (time > 0 && fired == true)
        {

            time -= Time.deltaTime;
        }
        if (time < 0.001f)
        {
            time = 2;
            fired = false;
        }



        //laser
        if (tme > 0 && burn == true)
        {

            tme -= Time.deltaTime;
        }
        if (tme < 0.0001f)
        {
            tme = 0.5f;
           burn = false;
        }

        if (tm > 0 && brn == true)
        {

            tm -= Time.deltaTime;
        }
        if (tm < 0.0001f)
        {
            tm = 5;
            brn = false;
        }


        //weapon system
        if (Input.GetKey(KeyCode.J)&&fired==false) {
            Instantiate(missile, missle, rotate);
            fired = true;

        }
        if (Input.GetKey(KeyCode.K) && burn == false)
        {
            Instantiate(laser, missle, rotate);
            burn = true;

        }
        if (Input.GetKey(KeyCode.L) && brn == false)
        {
            Instantiate(fire, missle, rotate);
            brn = true;

        }


        //void update bottom
    }

    void OnCollisionEnter2D(Collision2D coll) // C#, type first, name in second
    {
        if (coll.gameObject)
        {
            fly = 0;
            onplat = false;
            timer = 5.0f;
            swich = true;
        }
    }
    




}
