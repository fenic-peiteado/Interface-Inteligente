using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_distance_8 : MonoBehaviour
{
    private GameObject[] objectTypeTwo;
    private GameObject[] objectTypeOne;
    private GameObject changeColorObject;

    // Start is called before the first frame update
    void Start()
    {
        objectTypeOne = GameObject.FindGameObjectsWithTag("type_one");
        objectTypeTwo = GameObject.FindGameObjectsWithTag("type_two");
      //  GameObject[] unionArray = new GameObject[objectTypeOne.Length + objectTypeTwo.Length];
        Vector3 positionThis = transform.position;       
        //Distance 
        // float distanceToObjectClose = Mathf.Infinity;
        //  float distanceAux;
         GameObject ObjectClose = findminDistance(gameObject, objectTypeTwo);
         GameObject ObjectFar = findMaxDistance(gameObject, objectTypeTwo);
        // iterate in objectTypeTwo
        // ----------- Simplificar con una funcion minimo
        //  foreach(GameObject objectValue in objectTypeTwo) 
        //  {
        //      Vector3 valueVector = objectValue.GetComponent<Transform>().position;
        //      distanceAux = Vector3.Distance(positionThis, valueVector);
        //      if(distanceAux < distanceToObjectClose) {
        //          distanceToObjectClose = distanceAux;
        //          ObjectClose = objectValue;
        //      } 
        //  }
        // Change the position Y of ObjectClose
        Transform ObjectTransform = ObjectClose.GetComponent<Transform>();
        ObjectTransform.position += Vector3.up*5;
        changeColorObject = ObjectFar;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) 
        {
            Renderer rendereObject = changeColorObject.GetComponent<Renderer>();
            rendereObject.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

// ---------- Falta completar esta funcion y pasar los 2 array unido en uno
    GameObject findMaxDistance(GameObject elementObject, GameObject[] vectorOfElements )
    {
        float maxValue = -1;
        GameObject ObjecToReturned = null;
        Vector3 positionReference = elementObject.GetComponent<Transform>().position;
        foreach(GameObject MaxPossible in vectorOfElements) 
        {
            Vector3 positionOther = MaxPossible.GetComponent<Transform>().position;
            float distanceBetweenObject = Vector3.Distance(positionOther, positionReference);
            if (maxValue < distanceBetweenObject) {
                ObjecToReturned = MaxPossible;
                maxValue  = distanceBetweenObject;
            }
        }
        return ObjecToReturned;
    }

   GameObject findminDistance(GameObject elementObject, GameObject[] vectorOfElements) {
        float minValue = Mathf.Infinity;
        GameObject ObjecToReturned = null;
        Vector3 positionReference = elementObject.GetComponent<Transform>().position;
        foreach(GameObject MinPossible in vectorOfElements) 
        {
            Vector3 positionOther = MinPossible.GetComponent<Transform>().position;
            float distanceBetweenObject = Vector3.Distance(positionOther, positionReference);
            if (minValue > distanceBetweenObject) {
                ObjecToReturned = MinPossible;
                minValue  = distanceBetweenObject;
            }
        }
        return ObjecToReturned;
   }
}
