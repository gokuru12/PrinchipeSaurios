using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundointentocamara : MonoBehaviour
{
    public float dragSpeed;
    public float outerLeft;
    public float outerRight;
    public float outerDown;
    public float outerUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            var newPosition = new Vector3();
            newPosition.x = Input.GetAxis("Mouse X") * dragSpeed * Time.deltaTime;
            newPosition.z = Input.GetAxis("Mouse Y") * dragSpeed * Time.deltaTime;
            if(gameObject.transform.position.x > -outerLeft && gameObject.transform.position.x < outerRight && gameObject.transform.position.z > -outerDown && gameObject.transform.position.z < outerUp)
            {
                transform.Translate(-newPosition);
            }

            if (gameObject.transform.position.x < -outerLeft || gameObject.transform.position.x > outerRight || gameObject.transform.position.z < -outerDown || gameObject.transform.position.z > outerUp)
            {
                transform.Translate(newPosition);
            }
        }
    }
}
