using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockmove_R : MonoBehaviour
{
    //��� ���������θ� �����̱�   
    public float speed = 0.1f; //��� �ӵ� ����
    float x_Speed = 0; //x�� ���� ����
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //this.transform.Translate(speed / 25, 0, 0); //�����ʹ������� �̵�
        x_Speed = speed;

    }
    private void FixedUpdate()
    {

        this.transform.Translate(x_Speed,0,0); //������Ʈ �̵�

    }
}
