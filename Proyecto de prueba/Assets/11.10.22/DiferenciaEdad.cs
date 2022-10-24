using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiferenciaEdad : MonoBehaviour
{
    public int edad = 18;

    // Start is called before the first frame update
    void Start()
    {
        if (edad >= 18)
        {
            Debug.Log("Esta persona es mayor de edad");
        }
        else
        {
            Debug.Log("Esta persona es menor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
