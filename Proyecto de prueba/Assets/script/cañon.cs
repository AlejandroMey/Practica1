using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cañon : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bolacanonprefab;
    public float timeToShoot = 0;
    public float ShootForce;
    private float TimeSinceLastShoot;

    // Start is called before the first frame update
    private void Start()
    {
     
       
     
    }
    public void Shoot()
    {
        GameObject canonball = Instantiate(bolacanonprefab, shootPoint.position, shootPoint.rotation);
        Rigidbody canonballRigidbody = canonball.GetComponent<Rigidbody>();
        canonballRigidbody.AddForce(shootPoint.forward * ShootForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    private void Update()
    {
        TimeSinceLastShoot += Time.deltaTime;
        if (TimeSinceLastShoot >= timeToShoot)
        {
            Shoot();
            TimeSinceLastShoot = 1;
        }

    }
}
