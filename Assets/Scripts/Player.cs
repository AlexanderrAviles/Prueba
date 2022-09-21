using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private Rigidbody rb;
    public Text score;
    public float velocidad = 2000;
    public float velocidadX = 2000;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,velocidad*Time.deltaTime);
        var ejex = Input.GetAxis("Horizontal");
        //transform.Translate(new Vector3(ejex,0,0)*Time.deltaTime);       
        if (Input.GetKey("d"))
        {
            rb.AddForce(velocidadX*Time.deltaTime,0,0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-velocidadX*Time.deltaTime,0,0);
        }

        score.text = transform.position.z.ToString("0");
    }
}
