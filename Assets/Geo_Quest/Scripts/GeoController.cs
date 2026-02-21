using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{public int counter = 0;
    string train = "hello";
    // Start is called before the first frame update
   public void Start()
    {
        counter = 99;
        Debug.Log("Hello World");
        string hi = "world";
        Debug.Log(train + hi);
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(counter);
        counter++;
       if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
    }
}
