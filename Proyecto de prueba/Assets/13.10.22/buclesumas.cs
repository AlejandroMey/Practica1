using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buclesumas : MonoBehaviour
{
    public int min, max;
    // Start is called before the first frame update
    void Start()
    {
        int res = 0;
        for (int i = min; i <= max; i++)
        {
            res = res + i;   
        }
        Debug.Log(res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
