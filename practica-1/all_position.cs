using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class all_position : MonoBehaviour
{
    // Start is called before the first frame update
    // Variable Transform
    public Transform transform;
    // Variable Name
    void Start()
    {
          Debug.Log($"Nombre del objeto: {transform.gameObject.tag}, Posición: {transform.position}");
    }

    // Update is called once per frame
    void Update()//
    {

        
    }
}
