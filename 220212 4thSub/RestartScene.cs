using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //���ҷ����� ����Ҷ� �Է�
public class RestartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) //rŰ�� ��������
        {
            this.GetComponent<AudioSource>().Play(); // �Ҹ����
            SceneManager.LoadScene("SampleScene"); //SampleScene �ҷ�����
        }
    }
}
