using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fruit : MonoBehaviour
{
    public int points = 1;
    public bool isMerging;
    public GameObject nextFruit;
    public AudioClip sound;

    private  void OnCollisionEnter2D(Collision2D collision)
    {
        if (isMerging) return; 
       if(collision.gameObject.CompareTag("Cherry"))
        {
            var source = GetComponent<AudioSource>();
            source.clip = sound;
            source.Play();
        }
        if (!collision.gameObject.CompareTag("Strawberry")) return;
        if (points != collision.gameObject.GetComponent<Fruit>().points) return;

        isMerging = true;
        collision.gameObject.GetComponent<Fruit>().isMerging = true;

        var middlePos = (transform.position + collision.transform.position)/ 2;

        Destroy(gameObject);
        Destroy(collision.gameObject);

        Instantiate(nextFruit, middlePos, Quaternion.identity);
        
    }
    

}
