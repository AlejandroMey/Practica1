using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilLauncher : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject proyectilPrefab;
    public float timeToShoot = 0;
    public float TimeSinceLastShoot;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        TimeSinceLastShoot += Time.deltaTime;
        if (TimeSinceLastShoot >= timeToShoot)
        {
            Instantiate(proyectilPrefab, shootPoint.position, shootPoint.rotation);
            TimeSinceLastShoot = 0;
        }
    }
}