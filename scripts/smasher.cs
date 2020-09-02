using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smasher : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, 1) * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PatrolPoint")
        {
         speed = -speed;
        }
    }
}
