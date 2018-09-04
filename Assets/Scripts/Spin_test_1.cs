using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin_test_1 : MonoBehaviour {

    public float speed;
    public int rotate_speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVerti = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVerti);
        rb.AddForce(movement * speed);
    }

    void Update()
    {
        transform.Rotate(new Vector3 (0, 10, 0) * Time.deltaTime, rotate_speed);
    }
}
