using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI���� �ݵ�� �Է�
using UnityEngine.SceneManagement; //���ҷ����� ����Ҷ� �Է�


//ü�°��ý�ũ��Ʈ
public class HpControll : MonoBehaviour
{
    GameObject HpGauge;

    // Start is called before the first frame update
    void Start()
    {
        this.HpGauge = GameObject.Find("HpUi");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHP() //Hp���� �Լ��� ����
    {
        this.HpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if (this.HpGauge.GetComponent<Image>().fillAmount == 0) // ü���� 0�̵Ǹ� ���ӿ���
        {       
            SceneManager.LoadScene("GameOverScene"); //GameOverScene �ҷ�����
        }
    }
}