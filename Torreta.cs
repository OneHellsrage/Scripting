using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    [SerializeField] float magAngular = 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirAngular = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal2");
        Vector3 velAng = magAngular * dirAngular;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;
    }
}
