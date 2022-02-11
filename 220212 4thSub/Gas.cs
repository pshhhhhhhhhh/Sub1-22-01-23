using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ ��ũ��Ʈ
public class Gas : MonoBehaviour
{
    GameObject Player; //GameObject�� ������ ����
    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("player"); // �̸��� Player�� GameObject�� ���� Player�� ����
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.04f, 0);  // -y�������� �̵�
        if (transform.position.y < -4.8f) //ī�޶�ȭ�� ���� ��ǥ
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position; //�ڽ��� x,y ��ǥ���� ����p1�� ����
        Vector2 p2 = this.Player.transform.position; //player�� x,y��ǥ�� ����p2�� ����
        Vector2 dir = p1 - p2; //���� dir�� p1-p2 ���� ����
        float d = dir.magnitude; //���� dir�� ���̸� �Ǽ��� ��ȯ
        float r1 = 0.8f; //r1(�ڽ�)�� ������Ʈ�� ������
        float r2 = 1.0f;//r2(player) ������Ʈ�� ������
        float r3 = r1 + r2;
        if (d < r3)
        {
           GameObject soundplay = GameObject.Find("Sound"); // ���̾��Ű�� �ִ� Sound ȣ��
          soundplay.GetComponent<Sound>().playsound(); // �� �ȿ��ִ� ��ũ��Ʈ , playsound �Լ� ȣ��
            GameObject director = GameObject.Find("Hpplus"); // ���̾��Ű�� �ִ� HpPlus ȣ��
          director.GetComponent<Hpplus>().IncreaseHP(); // �� �ȿ��ִ� ��ũ��Ʈ , increseHP �Լ� ȣ��
           Destroy(gameObject);
        }
    }
}

