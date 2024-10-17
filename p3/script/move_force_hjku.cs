using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_force_hjku : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100.0f;
    public float torqueForce = 5.0f;
    private Rigidbody rigidBodyObject;
    void Start()
    {
        rigidBodyObject = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 MoveObject = Vector3.zero;

        //   if(Input.GetKey(KeyCode.H))
        ///   {
        ///      MoveObject = Vector3.left;
        //  }
        ///  if(Input.GetKey(KeyCode.K))
        ///   {
        ///      MoveObject = Vector3.right;
        /// }
        if (Input.GetKey(KeyCode.H))
        {
            rigidBodyObject.AddTorque(Vector3.up * -torqueForce *  Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K))
        {
            rigidBodyObject.AddTorque(Vector3.up * torqueForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J))
        {
            MoveObject = Vector3.back;
        }
        if (Input.GetKey(KeyCode.U))
        {
            MoveObject = Vector3.forward;
        }
        rigidBodyObject.AddForce(MoveObject * speed * Time.deltaTime);
    }
}
