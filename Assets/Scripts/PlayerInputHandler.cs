using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerInputHandler : MonoBehaviour
{
    // Start is called before the first frame update

    Movement movement;
    Vector3 scale = Vector3.one;

    void Awake()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            v.x = 1;
            scale.x = -1;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            v.x = -1;
            scale.x = 1;
        }

        movement.moveRb(v);
        movement.ScaleTransform(scale);
    }
}
