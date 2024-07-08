using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    // กำหนดตัวแปร public สำหรับเก็บชื่อฉากที่ต้องการโหลด
    public string sceneToLoadName;

    void Start()
    {
        // สร้างรายการฟังก์ชันที่จะถูกเรียกเมื่อปุ่มถูกกด
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(() => LoadSceneOnClick());
    }

    // ฟังก์ชันที่ถูกเรียกเมื่อปุ่มถูกกด
    void LoadSceneOnClick()
    {
        // โหลดฉากโดยใช้ชื่อฉากที่กำหนดในตัวแปร sceneToLoadName
        SceneManager.LoadScene(sceneToLoadName);
    }
}