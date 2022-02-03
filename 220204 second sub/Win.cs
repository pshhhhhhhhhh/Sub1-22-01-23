using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI���� �ݵ�� �Է�
using UnityEngine.SceneManagement; //���ҷ����� ����Ҷ� �Է�


public class Win : MonoBehaviour
{

    GameObject Player; //�÷��̾� ������Ʈ�� ������ ���� �������� GameObject
    GameObject gem; //��ǥ�� ������Ʈ�� ������ ���� �������� GameObjcet
    GameObject distance; //�÷��̾� ������Ʈ�� ��ǥ�� ������Ʈ ������ �Ÿ��� ǥ���� UI ������Ʈ�� ������ ����
    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");
        this.gem = GameObject.Find("gem");
        this.distance = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.gem.transform.position.x - this.Player.transform.position.x; // �� ����
        float lengthDis2 = this.gem.transform.position.y - this.Player.transform.position.y; // �� ����
       
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "Gem!" + " : " + lengthDis.ToString("F2") + "m";
            //ToString("D����") -> D�� ������ ���ڴ� �ڸ���   ToString("F����) -> �Ҽ������� �ڸ���
        }
        else //lengthDi�� 0���� �۴ٸ� -�� �Ÿ� ��Ÿ��
        {
            this.distance.GetComponent<Text>().text = "Gem!" + " : " + lengthDis.ToString("F2") + "m";
        }        
        if (lengthDis <= 0 && lengthDis2 <= 0) //������ ������ endScene �ҷ���
        {           
            SceneManager.LoadScene("EndScene");
        }
    }
}
