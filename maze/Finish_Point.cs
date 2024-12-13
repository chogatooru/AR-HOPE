using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Finish_Point : MonoBehaviour
{
    public Transform heartpo;
    public GameObject heart;
    Color heart_color;
    bool Isfinsh = false;
    public float speed = 5;
    float timer = 3;
    // Start is called before the first frame update
    void Start()
    {
        heart_color = heart.transform.GetComponent<SpriteRenderer>().color;
        //heart_color.g = 0f;
        //heart_color.b = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Isfinsh)
        {
            heart_color.g -= Time.deltaTime* speed;
            heart_color.b -= Time.deltaTime* speed;
            heart.transform.GetComponent<SpriteRenderer>().color = heart_color;
            
            timer -= Time.deltaTime;
            if (timer < 0)
            {
             //   SceneManager.LoadScene(0);
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            Isfinsh = true;
           // Destroy(gameObject);

        }
        if (collision.tag == "damage")
        {
            this.transform.position = heartpo.position;
           // Isfinsh = true;
            // Destroy(gameObject);

        }
    }
}
