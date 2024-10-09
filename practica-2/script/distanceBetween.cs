using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceBet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject CubeObject = GameObject.FindWithTag("green_cube");
        GameObject CylinderObject = GameObject.FindWithTag("red_cylinder");
        Transform TransformCube = CubeObject.GetComponent<Transform>();
        Transform TransCylinder = CylinderObject.GetComponent<Transform>();
        Vector3 positionCube = TransformCube.position;
        Vector3 positionCylinder = TransCylinder.position;
        Vector3 positionThis = gameObject.transform.position;
        Debug.Log("Distance to Cube: " + Vector3.Distance(positionCube, positionThis));
        Debug.Log("Distance to Cylinder: " + Vector3.Distance(positionCylinder, positionThis));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
