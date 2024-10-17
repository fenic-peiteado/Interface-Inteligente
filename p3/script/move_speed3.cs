using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_speed3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 moveDirection;
    public float speed = 1.0f;
    void Start()
    {
        Vector3 vectorAuxiliar = gameObject.transform.position;
        vectorAuxiliar.y = 2;
        gameObject.transform.position = vectorAuxiliar;
    }

    // Update is called once per frame
    void Update()
    {
        // Por defecto los ejes son locales, pero se puede cambiar con el parametro
        // Space relativeTo = Space.world
        gameObject.transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);     
    }
}
