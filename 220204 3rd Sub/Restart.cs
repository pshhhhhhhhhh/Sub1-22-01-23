using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //���ҷ����� ����Ҷ� �Է�

// Endscene -> SampleScene �ҷ�����
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) //r��ư �������� 
        {
            SceneManager.LoadScene("SampleScene"); //SampleScene �ҷ�����
        }
    }
}
