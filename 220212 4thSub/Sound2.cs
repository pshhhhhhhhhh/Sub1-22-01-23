using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI���� �ݵ�� �Է�

//�ǰݽ� �Ҹ���� ��ũ��Ʈ
public class Sound2 : MonoBehaviour
{
    GameObject Soundplayer2;
    // Start is called before the first frame update
    void Start()
    {
        this.Soundplayer2 = GameObject.Find("Sound2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playsound2() //�Ҹ� ��� �Լ� 
    {
        this.Soundplayer2.GetComponent<AudioSource>().Play();
    }
}
