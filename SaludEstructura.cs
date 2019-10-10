using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludEstructura : MonoBehaviour
{
    public int bida = 100;
    float t = 1.5f;
    void Update()
    {
        t += Time.deltaTime;
        if (bida <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void recibir_daño(int daño)
    {
        if (t >= 1.5)
        {
            bida -= daño/2;
            Debug.Log(bida);
            t = 0;
        }
    }

}
