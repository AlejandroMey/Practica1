using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float TimeToDestroy = 5;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, TimeToDestroy);
    }
}