using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontal_forward_8 : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadMovimiento = 5f;   // Velocidad de avance
    public float velocidadGiro = 100f;        // Velocidad de rotación
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotacion = Input.GetAxis("Horizontal");
        transform.Rotate(0, rotacion * velocidadGiro * Time.deltaTime, 0);
        // Mover el objeto hacia adelante según su orientación actual.
        transform.Translate(transform.forward * velocidadMovimiento * Time.deltaTime);

        
    }
}
