using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditorInternal;
using UnityEngine;

public class Fruit : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Fruit")) return;
        
        var middlePos = (transform.position + collision.transform.position)/ 2;

        Destroy(gameObject);
        Destroy(collision.gameObject);

        print("fruit");
    }

}
