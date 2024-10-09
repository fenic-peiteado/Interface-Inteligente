using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectors : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 VectorFirst;
    public Vector3 VectorSecond;
    void Start()
    {
        Debug.Log("Magnitude First: " + VectorFirst.magnitude);
        Debug.Log("Magnitude Second: " + VectorSecond.magnitude);
        float angle = Vector3.Angle(VectorFirst, VectorSecond);
        Debug.Log("Angle:" + angle);
        float dist = Vector3.Distance(VectorFirst, VectorSecond);
        if (VectorFirst[1] >= VectorSecond[1]) 
        {
            Debug.Log("The Major value for Y is First");
        } else
        {
            Debug.Log("The Major value for Y is Second");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
