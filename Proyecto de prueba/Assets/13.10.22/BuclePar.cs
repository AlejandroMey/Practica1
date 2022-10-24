using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuclePar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
