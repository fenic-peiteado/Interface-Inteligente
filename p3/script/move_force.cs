using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_force : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.0f;
    private Rigidbody rbObject;
    void Start()
    {
        rbObject = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
    rbObject.AddForce(movement * speed);
    }

}
