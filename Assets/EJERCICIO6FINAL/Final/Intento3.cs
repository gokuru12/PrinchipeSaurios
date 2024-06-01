using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intento3 : MonoBehaviour
{
    private float rotationSpeed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Mouse2))
        {
            CamOrbit();
        }
    }
    private void CamOrbit()
    {
        if(Input.GetAxis("Mouse Y") !=0 || Input.GetAxis("Mouse X") != 0)
        {
            float VerticalInput = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
            float HorizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.right, VerticalInput);
            transform.Rotate(Vector3.up, HorizontalInput, Space.World);
        }
    }

}
