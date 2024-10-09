using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorRandom : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject elementScene;
    public float frameLimit = 120;
    private Vector3 vectorColor;
    Renderer materialRd;
    void Start()
    {
        materialRd = elementScene.GetComponent<Renderer>();
        vectorColor = new Vector3(Random.value, Random.value,Random.value);
    }

    // Update is called once per frame
    static int count = 0;
    void Update()
    {
        if (count >= frameLimit) 
        {
            int valueRandom = Random.Range(1,3);
            vectorColor[valueRandom-1] = Random.value;             
            materialRd.material.color = new Color(vectorColor[0], vectorColor[1], vectorColor[2]);
            count = 0;
        }
        count++;
    }
}
