using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public GameObject[] objectsWithMaterial; // วัตถุที่มีเมททีเลีย
    private Material[] materialsToChange; // เมททีเลียที่ต้องการเปลี่ยนสี
    public Color targetColor; // สีที่ต้องการเปลี่ยนเป็น

    void Start()
    {
        // สร้างอาร์เรย์เพื่อจัดเก็บเมททีเลียของแต่ละวัตถุ
        materialsToChange = new Material[objectsWithMaterial.Length];

        // วนลูปผ่านวัตถุแต่ละตัว
        for (int i = 0; i < objectsWithMaterial.Length; i++)
        {
            // ดึงคอมโพเนนต์ Material จากแต่ละวัตถุ
            Renderer renderer = objectsWithMaterial[i].GetComponent<Renderer>();
            materialsToChange[i] = renderer.material;
        }
    }

    public void ChangeMaterialColor()
    {
        // วนลูปผ่านเมททีเลียแต่ละตัวในลิสต์
        foreach (Material material in materialsToChange)
        {
            material.color = targetColor; // เปลี่ยนสีของเมททีเลียเป็นสีที่กำหนด
        }
    }
}