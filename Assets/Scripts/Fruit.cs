using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public List<GameObject> fruits;
    public GameObject spawner;

     void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(worldMousePosition.x, transform.position.y, transform.position.z);
        OnClick();
    }

    public void OnClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("fruit");
            int randomIndex = Random.Range(0, fruits.Count);
            GameObject selectedObject = Instantiate(fruits[randomIndex], transform.position, Quaternion.identity);
        }
    }
}
