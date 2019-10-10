using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltar : MonoBehaviour
{
    float fuerza = 100;
    Rigidbody Mcuerpo;
    bool A;
    // Start is called before the first frame update
    void Start()
    {
        Mcuerpo = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        A = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (A == true && Input.GetKeyDown(KeyCode.H)) { 
            Mcuerpo.AddForce(Vector3.up * fuerza);
            A = false;
            Debug.Log("Saltando");
        }
    }
}
