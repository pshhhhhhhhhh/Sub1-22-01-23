using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockmove_updown : MonoBehaviour
{
   // ��� ���Ʒ��� �ݺ��ؼ� �����̱�
    public float maxCount = 1000.0f; //�ǵ��ƿ� ���� �������ִ� ����
    int count = 0;
    public float speed = 0.1f; // ��� �ӵ� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(count);
        // maxCount�� ������ �������� count�� maxcount�� ���ݺ��� ������ ���� Ŭ�� �Ʒ��� �̵�
        if (count < maxCount/2)
        {
            this.transform.Translate(0, speed / 25, 0); //���������� �̵�
            count++;
        }
        if(count >= maxCount/2 )
        {
            this.transform.Translate(0, -speed / 25, 0); //�Ʒ��������� �̵�
            count++;
            if(count == maxCount)
            {
                count = 0;
            }
        }
    }   
}
