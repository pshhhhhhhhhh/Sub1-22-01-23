using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockmove : MonoBehaviour
{
    //��� �翷���� �ݺ��ؼ� �����̱�
    
    public float maxCount = 1700.0f; //�ǵ��ƿö��� ���� ����
    int count = 0; 
    public float speed = 0.1f; //��� �ӵ� ����

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // maxCount�� ������ �������� count�� maxcount�� ���ݺ��� ������ �������� Ŭ�� ���������� �̵�
        if (count < maxCount / 2)
        {
            this.transform.Translate(-speed/25, 0, 0); //-�ʹ������� �̵�
            count++;
        }
        if (count >= maxCount / 2)
        {
            this.transform.Translate(speed/25,0, 0); //+�ʹ������� �̵�
            count++;
            if (count == maxCount)
            {
                count = 0;
            }
        }
    }
}
