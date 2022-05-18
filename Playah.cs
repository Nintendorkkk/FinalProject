using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playah : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] int health;
    [SerializeField] Vector2 minPos;
    [SerializeField] Vector2 maxPos;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, speed));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -speed));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        }
        if (transform.position.x < minPos.x)
        {
            transform.position = new Vector2(minPos.x, transform.position.y);
        }
        if (transform.position.y < minPos.y)
        {
            transform.position = new Vector2(transform.position.x, minPos.y);
        }
        if (transform.position.x > maxPos.x)
        {
            transform.position = new Vector2(maxPos.x, transform.position.y);
        }
        if (transform.position.y > maxPos.y)
        {
            transform.position = new Vector2(transform.position.x, maxPos.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;
            Destroy(collision.gameObject);
        }
    }
}
