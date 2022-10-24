using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class testfisica : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public Vector3 rigidbodyVelocity;
    public float forceMagnitude;
    public Vector3 forceDirection;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
     
    }

    // Update is called once per frame
    void Update()
    {
        rigidbodyVelocity = myRigidbody.velocity;


    }
    private void FixedUpdate()
    {
        myRigidbody.AddForce(forceDirection * forceMagnitude, ForceMode.Force);
    }
}


