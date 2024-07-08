using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithinBounds : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Plane plane;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    StartDragging();
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopDragging();
        }

        if (isDragging)
        {
            Plane plane = new Plane(Vector3.up, transform.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            float distance;
            if (plane.Raycast(ray, out distance))
            {
                Vector3 newPosition = ray.GetPoint(distance);
                newPosition.x = Mathf.Clamp(newPosition.x, -4.9f, 4.9f);
                newPosition.y = 0f;
                newPosition.z = Mathf.Clamp(newPosition.z, -4.9f, 4.9f);
                transform.position = newPosition;
            }
        }
    }

    private void StartDragging()
    {
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void StopDragging()
    {
        isDragging = false;
    }
}