using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCreator : MonoBehaviour
{
    public GameObject objectPrefab; // วัตถุที่ต้องการสร้าง
    public Transform spawnArea; // บริเวณที่ต้องการให้วัตถุถูกสร้างขึ้นมา

    void Start()
    {
        Button addButton = GetComponent<Button>(); // หาปุ่ม UI ที่เป็นตัวเรียกใช้ฟังก์ชันสร้างวัตถุ
        if (addButton != null)
        {
            addButton.onClick.AddListener(CreateObject); // เมื่อปุ่มถูกคลิก ให้เรียกฟังก์ชัน CreateObject
        }
        else
        {
            Debug.LogError("Button component not found!");
        }
    }

    void CreateObject()
    {
        if (objectPrefab != null && spawnArea != null)
        {
            // สร้างวัตถุในบริเวณที่กำหนด
            Instantiate(objectPrefab, spawnArea.position, objectPrefab.transform.rotation);
        }
        else
        {
            Debug.LogError("Object prefab or spawn area not assigned!");
        }
    }
}