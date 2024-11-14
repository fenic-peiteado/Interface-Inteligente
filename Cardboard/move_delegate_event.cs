using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_delegate_event : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public DragonCollecting cube;
    public GameObject toMove;
    bool moving = false;
    void Start()
    {
    cube.action += message;
    }

    // Update is called once per frame
    void Update()
    {
        if(moving)
        {
            Vector3 direction = toMove.transform.position - transform.position;
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }

    void message(string msg)
    {   
        if(msg == "move") 
        {
            moving = true;
        }
    }
}
