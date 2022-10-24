using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParImpar : MonoBehaviour
{
    // Start is called before the first frame update
    public int min, max;

    void Start()
    {
        if (min < max)
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Debug.Log("el " + i + " es Par");
                }
                else
                {
                    Debug.Log("el " + i + " es Impar");
                }
            }
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
