using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI���� �ݵ�� �Է�

public class GameDirector : MonoBehaviour
{
    GameObject player; //�÷��̾� ������Ʈ�� ������ ���� �������� GameObject
    GameObject bomb; //��ǥ�� ������Ʈ�� ������ ���� �������� GameObjcet
    GameObject distance; //�÷��̾� ������Ʈ�� ��ǥ�� ������Ʈ ������ �Ÿ��� ǥ���� UI ������Ʈ�� ������ ����
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("man");
        this.bomb = GameObject.Find("bomb");
        this.distance = GameObject.Find("Move");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.bomb.transform.position.x - this.player.transform.position.x;
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "��ǥ����" + ":" + lengthDis.ToString("F5") + "m";
            //ToString("D����") -> D�� ������ ���ڴ� �ڸ���   ToString("F����) -> �Ҽ������� �ڸ���
        }
        else //lengthDi�� 0���� �۴ٸ�
        {
            this.distance.GetComponent<Text>().text = "Game Over"; // Game Over �޽��� ���
        }
    }
}
