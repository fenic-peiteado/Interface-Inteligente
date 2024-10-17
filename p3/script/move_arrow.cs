using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.0f;
    void Start()
    {
    // Se puede hacer porque solo hay una instancia global de este sino habria que buscarlo o asociarlo
    }

    // Update is called once per frame
    void Update()
    {
        // Se logra gracias a que la velocida es una variable static y no necesita de una instancia para acceder
        if(Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * speed);
        } else if (Input.GetKey("down")) 
        {
            transform.Translate(Vector3.back * speed);
        } else if (Input.GetKey("left")) 
        {
            transform.Translate(Vector3.left * speed);
        } else if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * speed);
        }
    }
}
