using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Scene_2";
    /*{public int counter = 0;
        string train = "hello";*/
    // Start is called before the first frame update
    public void Start() { 
    /*{
        counter = 99;
        Debug.Log("Hello World");
        string hi = "world";
        Debug.Log(train + hi);
    }*/
   
  rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {

        switch (collision.tag)
        {
            case "Death":
                { 
                string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                    }
            case "Finish":
                {                     SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "coin":
                {
                   Destroy(collision.gameObject);
                    break;
                }
        }
    }
    private void Update()
    {
    float xInput = Input.GetAxis("Horizontal");
         rb.velocity = new Vector2(xInput* speed, rb.velocity.y);
        //Debug.Log(xInput);
        /*  Debug.Log(counter);
      
        counter++;        
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 3, 0);
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
     */
    }
}
