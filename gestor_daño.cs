using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestor_daño : MonoBehaviour
{   
    public string objetivo;
    public int daño;
        private void OnCollisionEnter(Collision collision){

        if (collision.collider)
        {
            if (collision.collider.tag == objetivo)
            {
                collision.gameObject.GetComponent<Salud>().recibir_daño(daño);
            }else if(collision.collider.tag == "Construccion")
            {
                collision.gameObject.GetComponent<SaludEstructura>().recibir_daño(daño);
            }
            Destroy(gameObject);
        }
    }
}
