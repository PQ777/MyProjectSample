using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthSample : MonoBehaviour
{
    private Transform myTransform = null;
    public Vector3 offsetVector3 = Vector3.zero;    // �����̸� 0, 0, 0 �̴�
    public float Speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        // ĳ��
        //transform �Ⱦ�, �Ҷ����� �Ź� ���� �ϱ� ����, ��� �������͸� �ҷ����� ����
        if (myTransform == null)
        {
            myTransform = GetComponent<Transform>();
        }

        
        //myTransform.position += offsetVector3;
        //myTransform.Translate(offsetVector3 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        // ���ӿ� ������Ʈ �̵�
        myTransform.Translate(offsetVector3 * Speed * Time.deltaTime);
    }
}
