using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{

    Rigidbody2D rb;
    AudioSource scr;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        scr = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        scr.Play();
    }
}
