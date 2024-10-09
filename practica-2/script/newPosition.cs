using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPosition : MonoBehaviour
{
    // Start is called before the first frame update
        Vector3 positionFirst = new Vector3(1, 2, 3);
        Vector3 positionSecond = new Vector3(2, 3, 4);
        Vector3 positionThird = new Vector3(3, 5, 6);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")) {
            transform.position = transform.position + positionFirst; 
        }
        
    }
}
