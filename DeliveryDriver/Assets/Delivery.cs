using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Mr.Drivery : Ouch!");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked Up");
        }
        else if (other.tag == "Customer")
        {
            Debug.Log("Package Here !");
        }
    }

}
