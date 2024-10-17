using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionCylinder9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        // Ejemplo de colision
        Debug.Log("Hubo una colicion : " + collision.gameObject.name);
    }
}
