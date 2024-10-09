using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform tranformSphere = gameObject.GetComponent<Transform>();
        Debug.Log("Position of Sphere is " + tranformSphere.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
