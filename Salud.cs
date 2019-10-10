using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public int bida = 3;
    float t = 1.5f;
    // Update is called once per frame
    void Update()
    {
      t += Time.deltaTime;
      if (bida <=0)
        {
            Destroy(gameObject);
        }
    }
    public void recibir_daño(int daño)
    {
        if (t >= 1.5)
        {
            bida -= daño;
            Debug.Log(bida);
            t = 0;
        }
    }
}
