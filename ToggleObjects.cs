using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToggleObjects : MonoBehaviour
{
    public List<GameObject> objectsToToggle; // รายการของวัตถุที่ต้องการเปิดและปิดการใช้งาน
    private bool areObjectsActive = false; // สถานะปัจจุบันของการใช้งานของวัตถุทั้งหมด

    public void Toggle()
    {
        areObjectsActive = !areObjectsActive; // สลับสถานะของการใช้งานวัตถุทั้งหมด
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(areObjectsActive); // เปิดหรือปิดการใช้งานวัตถุทั้งหมดตามสถานะใหม่
        }
    }
}
