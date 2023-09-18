using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed = 2f;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.fixedDeltaTime;
    }
}
