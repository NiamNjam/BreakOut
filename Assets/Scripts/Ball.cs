using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 10f;
    public GameObject enemy;
    public AudioClip sound;
    public AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-1f, 1f), 1);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var brick = collision.gameObject.GetComponent<Brick>();
        if (brick)
        {
            source.clip = sound;
            source.Play();
            brick.Damage();
        }

        else if (collision.gameObject.CompareTag("Enemy"))
        {
            print("found");
            transform.position = new Vector3(0, 0, 0);
            GameManager.lives--;
        }
    }



}
