using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meses : MonoBehaviour
{
    public int mes;
    // Start is called before the first frame update
    void Start()
    {
        switch (mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Debug.Log("tiene 31 dias");
                break;
            case 4:
            case 9:
            case 11:
                Debug.Log("tiene 30 dias");
                break;
            case 2:
                Debug.Log("tiene 28 dias");
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
