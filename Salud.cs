using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{
    public int bida = 100;
    float t = 1.5f, C = 0;
    bool A = true;
    Renderer Mcuerpo;
    private void Awake()
    {
        Mcuerpo = GetComponent<Renderer>();
    }
    void Update()
    {
        if (C > 5) A = true;
        t += Time.deltaTime;
        C += Time.deltaTime;
        if (bida <=0)
        {
            Destroy(gameObject);
        }
    }
    public void Estrellita()
    {
        C = 0;
        A = false;
    }  
    public void recibir_daño(int daño)
    {
        if (t >= 1.5 && A == true)
        {           
            bida -= daño;
            t = 0;            
        }
    }
    public void curarse()
    {
        bida += 10;
    }    
}
