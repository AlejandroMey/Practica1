using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buclemultipl : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        int res = 1;
        for (int i = num; i > 0; i--)
        {
            res *= i;
        }
        Debug.Log(res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
