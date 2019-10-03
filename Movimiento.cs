using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float magnitud = 8;
    [SerializeField] float magAngular = 90;
    AudioSource Maudio;
    Rigidbody mCuerpo;
    float T = 0f;
    void Start()
    {
        Maudio = GetComponent<AudioSource>();
        mCuerpo = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float MagFuerzaV = 100f;
        float senV = 1;
        Vector3 dirV = transform.up;
        Vector3 fuerzaV = MagFuerzaV * dirV * senV;
        float MagFuerzaH = 2000f;
        float senH = 1;
        Vector3 dirH = transform.forward;
        Vector3 fuerzaH = MagFuerzaH * dirH * senH;
        Vector3 dir = transform.forward * Input.GetAxis("Vertical");
        Vector3 velocidad = magnitud * dir;
        Vector3 distancia = velocidad * Time.deltaTime;
        transform.position += distancia;
        Vector3 dirAngular = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");
        Vector3 velAng = magAngular * dirAngular;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0){
            Maudio.mute = false;
        }
        else{
            Maudio.mute = true;
        }
        if (Input.GetButtonDown("Jump") && mCuerpo.position.y < 1)
        {
            T += Time.deltaTime;
            mCuerpo.AddForce(fuerzaH);
            mCuerpo.AddForce(fuerzaV);            
        }
        if (T > 1 && T < 1.3)
        {
            mCuerpo.velocity = Vector3.zero;
            T = 0f;
        }

    }
}
