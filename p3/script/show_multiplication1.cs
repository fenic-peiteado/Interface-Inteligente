using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_multiplication : MonoBehaviour
{
    // Start is called before the first frame update
    public float atributeVelocity = 0.0f;
    private float multiplicationPosition;
    void Start()
    {
        float positionHorizontal = transform.position[0];
        float positionVertical = transform.position[1];
        // Se hace asi ya que el objeto sera un static collider en este caso
        multiplicationPosition =  positionVertical * positionHorizontal;
    }

    // Update is called once per frame
    void Update()
    {
        // Pone que hay que utilizar las clas Input y KeyCode
        float variablePrint = 0.0f;
        float moventInV = Input.GetAxis("Vertical");
        float moventInH = Input.GetAxis("Horizontal");
        // Diferencia se recomienda
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            variablePrint = atributeVelocity * multiplicationPosition;
            Debug.Log($"se presionó la tecla up {variablePrint}" );
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            variablePrint = atributeVelocity * multiplicationPosition;
            Debug.Log($"se presionó la tecla down, valor : {variablePrint}");
        }
        if (Input.GetKey("left"))
        {
            variablePrint = atributeVelocity * multiplicationPosition;
            Debug.Log($"se presionó la tecla left, valor : {variablePrint}");
        }        
        if (Input.GetKey("right"))
        {
            variablePrint = atributeVelocity * multiplicationPosition;
            Debug.Log($"se presionó la tecla right, valor: {variablePrint}");
        }
    }
}
