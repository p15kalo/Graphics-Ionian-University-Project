using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyoncontact : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            Destroy(collision.gameObject);
        }
    }
}

// Update is called once per frame

