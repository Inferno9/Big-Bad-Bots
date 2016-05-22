using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour
{
    private bool rightleft;



    // Use this for initialization
    void Start()
    {

        if (Input.GetKey(KeyCode.A))
        {
            rightleft = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rightleft = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (rightleft == false)
        {
            transform.position += transform.right *5.5f * Time.deltaTime;


        }
        if (rightleft == true)
        {
            transform.position -= transform.right * 5.5f * Time.deltaTime;

        }


        Destroy(gameObject, 5);


    }


}