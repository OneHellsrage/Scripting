using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrella : MonoBehaviour
{
    private void OnCollisionEnter(Collision Hestrella)
    {
        if (Hestrella.collider.tag == "Jugador" || Hestrella.collider.tag == "Jugador2")
        {
            Hestrella.gameObject.GetComponent<Salud>().Estrellita();
            Destroy(gameObject);
        }
    }
}
