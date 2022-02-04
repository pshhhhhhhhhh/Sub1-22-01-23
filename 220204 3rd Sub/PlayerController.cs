using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   
    float speed2 = 0; //���� ����
    Vector2 startPos; //���콺�� Ŭ������ �� ��ǥ��
    Vector2 endPos; // ���콺�� ������ �������� ��ǥ��
    public float littley = 1000.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) //���콺 ����Ŭ���� ��ȣ�ۿ�
        {
            this.startPos = Input.mousePosition; //���콺��ư Ŭ���������� ��ġ��

                
        }
       else if (Input.GetMouseButtonUp(0))
        {
             this.endPos = Input.mousePosition; //���콺��ư Ŭ���ߴٰ� ������ �� ��ġ��
           
            float length2 = (this.endPos.y - this.startPos.y); //������ ��ǥ�� - ó�� ��ǥ���� ����
          
            this.speed2 = length2 / littley;
            this.GetComponent<AudioSource>().Play(); //Ŭ���Ҷ����� �Ҹ� ������

        } 


        
        transform.Translate(0.02f, this.speed2 * Time.deltaTime, 0); // y+�������� �̵���Ŵ , Time.deltaTime -> ��� ��翡 ������� �̵� �ӵ��� ���� ��
        this.speed2 *= 0.5f; //0�� �������� ���ӽ�Ŵ
    }

    
}
