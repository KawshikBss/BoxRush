using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleMovement : MonoBehaviour
{
    public float speed = 1.5f;
    public bool verticalMovement = false;
    public bool horizontalMovement = false;
    private Vector3 position;
    void Start() {
        position = transform.position;
    }
    void FixedUpdate()
    {
        if (verticalMovement)
            position.y += Mathf.Sin(Time.time * speed);
        if (horizontalMovement)
            position.x += Mathf.Sin(Time.time * speed);
        transform.position = position;
    }
}
