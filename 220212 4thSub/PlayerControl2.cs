using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ư���� �����̴� ��ũ��Ʈ
public class PlayerControl2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LButtonDown()
    {
        transform.Translate(-0.1f, 0, 0);

    }
    public void RButtonDown()
    {
        transform.Translate(0.1f, 0, 0);

    }
}
