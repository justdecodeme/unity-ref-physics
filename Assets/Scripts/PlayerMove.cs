using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    private float _x = 0f;
    private float _y = 0f;
    public float _z = 0f;
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update for input
    void Update()
    {
        _x = Input.GetAxis("Horizontal") * speed;
        // _z = Input.GetAxis("Vertical") * speed;
        // if(_x < -4.4f) _x = -4.4f;
        // if(_x > 4.4f) _x = 4.4f;
        movement = new Vector3(_x, _y, _z);
        
        Debug.Log(_x);

    }

    // Update for physics 
    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 direction) {
        // rb.AddForce(_x, _y, _z);
        rb.velocity = direction;
        // rb.MovePosition(transform.position + (direction * Time.deltaTime));
    }
}
