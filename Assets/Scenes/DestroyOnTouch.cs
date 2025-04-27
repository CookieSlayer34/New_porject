using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    [Tooltip("Tag of the object that will destroy this one on contact.")]
    public string targetTag = "Destroyer";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == targetTag)
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == targetTag)
        {
            Destroy(other.gameObject);
        }
    }
}
