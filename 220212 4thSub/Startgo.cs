using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //���ҷ����� ����Ҷ� �Է�


//���þ� �ҷ����� ��ũ��Ʈ
public class Startgo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) //�����̽� �� ��������
        {
            this.GetComponent<AudioSource>().Play(); // �Ҹ����
            SceneManager.LoadScene("SampleScene"); //SampleScene �ҷ�����
        }
    }
}
