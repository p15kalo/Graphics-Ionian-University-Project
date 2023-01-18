using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float timeUntilSpawn;
    private bool spawn = true;
    public int count = 0;
    void Start()
    {   
    }

    void Update()
    {
        if (spawn)
        {
            Invoke("Spawn", timeUntilSpawn);
            spawn = false;
        }
    }

    void Spawn()
    {
        spawn = true;
        GameObject newSphere = Instantiate(prefab);
        newSphere.name = "Sphere_clone";
        bool daBomb = (count + 1) % 5 == 0 && count != 0;
        if (daBomb)
        {
            newSphere.GetComponent<Rigidbody>().AddRelativeForce(
                new Vector3((float)Math.Cos(Math.PI * count / 7),
                -500,
                (float)Math.Cos(Math.PI * count / 7))
            );
        }
        newSphere.GetComponent<Rigidbody>().AddRelativeForce(
                new Vector3(0, -700, 0));
        newSphere.transform.position = new Vector3(0, 70f, 0);

            count++;
    }
}