using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI���� �ݵ�� �Է�


//ü�°��ý�ũ��Ʈ
public class Hpplus : MonoBehaviour
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
    public void IncreaseHP() //Hp���� �Լ��� ����
    {
        this.HpGauge.GetComponent<Image>().fillAmount += 0.1f;
    }
}
