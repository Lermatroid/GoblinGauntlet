using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] float speed = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveTransform(Vector3 v)
    {
        transform.position += v * Time.deltaTime;
    }

    public void moveRb(Vector3 v)
    {
        rb.velocity = v * speed;
    }

    public void ScaleTransform(Vector3 v)
    {
        transform.localScale = v;
    }
}
