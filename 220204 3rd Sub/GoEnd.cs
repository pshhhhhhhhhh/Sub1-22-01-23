using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //���ҷ����� ����Ҷ� �Է�

public class GoEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) //�ݶ��̴�,������ٵ� ����� ������Ʈ�� �浹�ϸ� ����
    {

        SceneManager.LoadScene("EndScene"); //endScene �ҷ�����

    }
}
