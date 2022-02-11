using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�� ���� ��ũ��Ʈ
public class EnemyGenerator : MonoBehaviour
{
    public GameObject copyedEnemy;
    float respawn = 0.3f; //������ ������Ʈ�� ��Ÿ���½ð�(�������ð�)
    float delta = 0; //�ð��� ���ϱ� ���� �ð� ����
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta = this.delta + Time.deltaTime;
        if(this.delta > this.respawn)
        {
            this.delta = 0;
            GameObject showEnemy = Instantiate(copyedEnemy) as GameObject;
            float range = Random.Range(-9.0f, 9.0f);//Random.Range(�ּҰ�,�ִ밪)
            showEnemy.transform.position = new Vector3(range, 6, 0);
        }
    }
}
