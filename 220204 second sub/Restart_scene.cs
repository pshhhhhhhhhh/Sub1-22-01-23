using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //���ҷ����� ����Ҷ� �Է�

public class Restart_scene : MonoBehaviour
    // R������ ������ϱ�
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r") || Input.GetKey("space")) //rŰ Ȥ�� �����̽��� ������ samplescene �ҷ��ͼ� ������ϱ�
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
