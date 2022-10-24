using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dias : MonoBehaviour
{
    public int dia;
    public int mes;
    // Start is called before the first frame update
    void Start()
    {
        switch (dia)
        {
            case 1:
                Debug.Log("es lunes");
                break;
            case 2:
                Debug.Log("es martes");
                break;
            case 3:
                Debug.Log("es miercoles");
                break;
            case 4:
                Debug.Log("es jueves");
                break;
            case 5:
                Debug.Log("es viernes");
                break;
            case 6:
                Debug.Log("es sabado");
                break;
            case 7:
                Debug.Log("es domingo");
                break;
            default:
                Debug.Log("No existe dia");
                break;
        }
        switch (mes)
        {
            case 1:
                Debug.Log("es enero");
                break;
            case 2:
                Debug.Log("es febrero");
                break;
            case 3:
                Debug.Log("es marzo");
                break;
            case 4:
                Debug.Log("es abril");
                break;
            case 5:
                Debug.Log("es mayo");
                break;
            case 6:
                Debug.Log("es junio");
                break;
            case 7:
                Debug.Log("es julio");
                break;
            case 8:
                Debug.Log("es agosto");
                break;
            case 9:
                Debug.Log("es septiembre");
                break;
            case 10:
                Debug.Log("es octubre");
                break;
            case 11:
                Debug.Log("es noviembre");
                break;
            case 12:
                Debug.Log("es diciembre");
                break;
            default:
                Debug.Log("No existe mes");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
