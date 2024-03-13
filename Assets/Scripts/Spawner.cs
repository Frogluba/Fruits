using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public List<GameObject> fruits;
    public TMP_Text  text1;
    public TMP_Text text2;
  
    void  Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        float clampedX = Mathf.Clamp(worldMousePosition.x, Camera.main.ViewportToWorldPoint(Vector3.zero).x, Camera.main.ViewportToWorldPoint(Vector3.one).x);
        transform.position = new Vector2(clampedX, transform.position.y);
        OnClick();
        
    }

     public void OnClick()
    {
  
        if (Input.GetMouseButtonDown(0))
        {
            text1.text = "";
            text2.text= "";
            
            int randomIndex = Random.Range(0, fruits.Count);
            GameObject selectedObject = Instantiate(fruits[randomIndex], transform.position, Quaternion.identity);
        }

        
    }
}
