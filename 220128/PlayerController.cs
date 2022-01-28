using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 0; //���� ����
    Vector2 startPos; //���콺�� Ŭ������ �� ��ǥ��
    Vector2 endPos; // ���콺�� ������ �������� ��ǥ��
    public float little = 1000.0f;
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
            float length = (this.endPos.x - this.startPos.x); //������ ��ǥ�� - ó�� ��ǥ���� ����
            this.speed = length / little;
            this.GetComponent<AudioSource>().Play();

        } 


        //if (Input.GetMouseButton(1)) //���콺 ��������Ŭ���� ��ȣ�ۿ�
        //{
        //    this.speed = -0.1f; // ���ۼӵ� ����         
        //}
        transform.Translate(this.speed*Time.deltaTime, 0, 0); // x+�������� �̵���Ŵ , Time.deltaTime -> ��� ��翡 ������� �̵� �ӵ��� ���� ��
        this.speed *= 0.98f; //0�� �������� ���ӽ�Ŵ
    }
}
