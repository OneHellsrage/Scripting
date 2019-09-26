using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
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
        Color A = new Color(0, 0, 1);
        Color R = new Color(1, 0, 0);
        Color B = new Color(1, 1, 1);

        if (Mluz.intensity >= 0.25 && Mluz.intensity < 0.5)
        {
            Mluz.color = A;
        }
        if (Mluz.intensity >= 0.5 && Mluz.intensity < 0.75)
        {
            Mluz.color = R;
        }
        if (Mluz.intensity >= 0.75)
        {
            Mluz.color = B;
        }
    }
}
