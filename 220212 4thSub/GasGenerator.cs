using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//������ ȸ������ ��ũ��Ʈ
public class GasGenerator : MonoBehaviour
{
    public GameObject copyedGas;
    float respawn = 1.0f; //������ ������Ʈ�� ��Ÿ���½ð�(�������ð�)
    float delta = 0; //�ð��� ���ϱ� ���� �ð� ����
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta = this.delta + Time.deltaTime;
        if (this.delta > this.respawn)
        {
            this.delta = 0;         
                GameObject showGas = Instantiate(copyedGas) as GameObject;
                float range = Random.Range(-9.0f, 9.0f);//Random.Range(�ּҰ�,�ִ밪)
                showGas.transform.position = new Vector3(range, 6, 0);
        }       
    }
}
