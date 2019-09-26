using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4 : MonoBehaviour
{
    Light Mluz;
    // Start is called before the first frame update
    void Start()
    {
        Mluz = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Mluz.intensity = (0.5f) * Mluz.transform.localScale.magnitude;
    }
}
