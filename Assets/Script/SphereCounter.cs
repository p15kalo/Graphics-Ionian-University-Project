using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereCounter : MonoBehaviour
{
    public Text countText;
    public GameObject Spheres;

    void Update()
    {
        int count = 0;
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();

        for (int i = 0; i < allObjects.Length; i++)
        {
            if (allObjects[i].CompareTag("Sphere"))
            {
                count++;
            }
        }

        countText.text = "Sphere Count: " + count;
    }
}