using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//��ü ȸ�� ��ũ��Ʈ
public class Rcon : MonoBehaviour
{


    public float rotSpeed = 1; //ȸ���ӵ� �ʱⰪ
    float rot_Z = 0;
    void Update()
    {

        rot_Z = rotSpeed;

        transform.Rotate(0, 0, rot_Z); //+�������� ȸ��
        this.rot_Z *= 0.96f; //���� 0�� �����ϵ��� ��
    }   
}
