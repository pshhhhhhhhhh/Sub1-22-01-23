using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ĳ���� �����̱�
public class Player_move : MonoBehaviour
{
    public float move_Speed = 0.1f; //�ӵ��ʱⰪ
    float x_Speed = 0; //x�� ���� ����
    float y_Speed = 0; //y�� ���� ����
   
    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {  
        x_Speed = 0;
        y_Speed = 0;
         
        if (Input.GetKey("right")) //���������� �̵�
        {           
            x_Speed = move_Speed;                   
        }
        if (Input.GetKey("left")) //�������� �̵�
        {          
            x_Speed = -move_Speed;           
        }
        if (Input.GetKey("up"))//���� �̵�
        {
            y_Speed = move_Speed;
        }
        if (Input.GetKey("down"))//�Ʒ��� �̵�
        {
            y_Speed = -move_Speed;
        }
    }
    private void FixedUpdate()
    {      
        this.transform.Translate(x_Speed, y_Speed, 0); //������Ʈ �̵�       
    }   
}

