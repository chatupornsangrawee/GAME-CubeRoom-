using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // ตรวจสอบว่าวัตถุที่ถูกคลิกเป็นตัวเองหรือไม่
                if (hit.collider.gameObject == gameObject)
                {
                    // หมุนวัตถุทีละ 90 องศาในแกน Y
                    transform.Rotate(0f, 90f, 0f);
                }
            }
        }
    }
}