using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI���� �ݵ�� �Է�

// ������ ȹ��� �Ҹ���� ��ũ��Ʈ
public class Sound : MonoBehaviour
{
    GameObject Soundplayer;

    // Start is called before the first frame update
    void Start()
    {
        this.Soundplayer = GameObject.Find("Sound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playsound() //�Ҹ� ��� �Լ� 
    {
        this.Soundplayer.GetComponent<AudioSource>().Play();
    }
}
