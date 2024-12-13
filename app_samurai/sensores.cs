using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sensores : MonoBehaviour
{
    // Start is called before the first frame update
    //Texto
    public TextMeshProUGUI velocidad_angular;
    public TextMeshProUGUI latitude;
    public TextMeshProUGUI longitude;
    public TextMeshProUGUI altitude;
    public TextMeshProUGUI acelerometer;
    public TextMeshProUGUI gravity_t;
    public float rotationSpeed = 1.0f;
    public float movementSpeed = 1.0f;
    public GameObject samurai;
    void Start()
    {

        Input.compass.enabled = true;
        Input.location.Start();
        // StartCoroutine("LocationCoroutine");
        Input.gyro.enabled = true;
        //  Input.compass.enabled = true;   
        if (Input.location.isEnabledByUser)
        {
            velocidad_angular.text = "Compass: " + Input.compass.trueHeading;
            latitude.text = "Latitude: " + Input.location.lastData.latitude;
            longitude.text = "Longitude: " + Input.location.lastData.longitude;
            altitude.text = "Altitude: " + Input.location.lastData.altitude;
            acelerometer.text = "Acelerometer: " + Input.acceleration;
            gravity_t.text = "Gravity: " + Input.gyro.gravity;
        }
        else
        {
            Debug.Log("No esta servicio  de localización activado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            Input.location.Start();
            velocidad_angular.text = "Velocidad W: " + Input.gyro.rotationRate.ToString();
            latitude.text = "Latitude: " + Input.location.lastData.latitude;
            longitude.text = "Longitude: " + Input.location.lastData.longitude;
            altitude.text = "Altitude: " + Input.location.lastData.altitude;
            acelerometer.text = "Acelerometer: " + Input.acceleration;
            gravity_t.text = "Gravity: " + Input.gyro.gravity;

            //Gira al samurai al norte y caminar en esa direecion
            
            Quaternion targetRotation = Quaternion.Euler(0, Input.compass.trueHeading, 0);
            // Aplica interpolación suave para rotar el samurái
            samurai.transform.rotation = Quaternion.Slerp(samurai.transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            Vector3 acceleration = Input.acceleration;
            float forwardSpeed = -acceleration.z * movementSpeed; // Invertimos el eje Z
            samurai.transform.Translate(forwardSpeed*Vector3.forward * Time.deltaTime);
        }
        //  else
        // {
        // Debug.Log("No esta funcionando el servicio");
        // }
    }

    
}
