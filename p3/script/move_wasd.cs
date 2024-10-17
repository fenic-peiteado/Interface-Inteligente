using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_wasd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float vercticalValue = Input.GetAxis("Vertical");
    
        gameObject.transform.Translate(horizontalValue, 0, vercticalValue);
        
    }
}
