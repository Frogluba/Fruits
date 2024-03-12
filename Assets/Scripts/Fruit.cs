using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject colided;
    public GameObject apeared;
    private bool hasCollided = false;

    private void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasCollided && collision.gameObject.CompareTag(this.gameObject.tag))
        {
            

            // Destroy both colliding objects
            Destroy(this.gameObject);
            Destroy(collision.gameObject);

            // Instantiate a new object at the collision point
            Instantiate(apeared, collision.GetContact(0).point, Quaternion.identity);
        }
    }


}
