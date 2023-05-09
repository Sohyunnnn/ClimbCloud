using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudDestory : MonoBehaviour
{
    GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisonEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("cloudPrefab"))
        {
            Destroy(collision.gameObject, 5);
            Debug.Log("Ãæµ¹");
        }
    }
}
