using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightsliderScript : MonoBehaviour
{
    public Slider Lightslider;
    public Light Spotlight;
    // Start is called before the first frame update
    void Start()
    {
        Lightslider.value = Spotlight.intensity;

    }
    // Update is called once per frame
    void Update()
    {
        Spotlight.intensity = Lightslider.value;
    }
}
