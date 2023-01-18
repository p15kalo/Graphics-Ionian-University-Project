using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereCounter : MonoBehaviour
{
    public Text countText;
    public SphereSpawner Spheres;
    public int count = 0;
    void Update()
    {
        count = Spheres.count;
        countText.text = "Sphere Count: " + count;
    }
}