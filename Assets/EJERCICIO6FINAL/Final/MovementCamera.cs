using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCamera : MonoBehaviour
{
    private bool dragPanMoveActive;
    private Vector2 lastMousePosition;

   

    // Update is called once per frame
    void Update()
    {
        Vector3 inputDir = new Vector3(0, 0, 0);
        if (Input.GetMouseButtonDown(1))
        {
            dragPanMoveActive = true;
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(1))
        {
            dragPanMoveActive = false;
            lastMousePosition = Input.mousePosition;
        }

        if (dragPanMoveActive)
        {
            float dragPanSpeed = 2f;
            Vector2 mouseMovementDelta = (Vector2)Input.mousePosition - lastMousePosition;

            inputDir.x = mouseMovementDelta.x;
            inputDir.y = mouseMovementDelta.y;

            lastMousePosition = Input.mousePosition;
        }

        Vector3 moveDir = transform.forward * inputDir.z + transform.right * inputDir.x;

        float moveSpeed = 30f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;

    }

   
}
