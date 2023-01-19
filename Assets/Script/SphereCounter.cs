using TMPro;
using UnityEngine;

public class SphereCounter : MonoBehaviour
{
    public TMP_Text countText;
    public SphereSpawner Spheres;
    public int count = 0;

    void Start()
    {
     
    }

    void Update()
    {
        count = Spheres.count;
        countText.text = "Sphere Count: " + count;
    }
}