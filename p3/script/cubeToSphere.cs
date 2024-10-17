using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Ejercicio 6, 7, 8

public class cubeToSphere : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform Sphere;
    void Start()
    {
        Sphere = GameObject.FindWithTag("sphere").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Look para poner el objeto cube viendo al esefera ejercicio 7
        transform.LookAt(Sphere);
        Vector3 direction = -(transform.position - Sphere.position);
        direction = Vector3.Normalize(direction);
        direction.y = 0;
        transform.Translate(direction * Time.deltaTime, Space.World);
        // Añadi una rotacio en Horizontal del objeto y que siempre de frente 
        transform.Rotate(Vector3.up * Time.deltaTime * 100);
        
    }
}
