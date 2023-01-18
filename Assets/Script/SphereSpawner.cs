using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float timeUntilSpawn = 10f;
    private bool hasSpawned = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (!hasSpawned)
        {
            Invoke("Spawn", timeUntilSpawn);
            hasSpawned = true;
        }
        GameObject originalSphere = GameObject.Find("Sphere");
        if (originalSphere != null)
        {
            if (originalSphere.transform.position.y < -15)
            {
                originalSphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
                originalSphere.GetComponent<Renderer>().enabled = false;
            }
        }
    }

    void Spawn()
    {
        GameObject newSphere = Instantiate(prefab);
        newSphere.name = "Sphere_clone";
        newSphere.transform.position = new Vector3(0, 50f, 0);
    }
}