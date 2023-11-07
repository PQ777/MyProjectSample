using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthSample : MonoBehaviour
{
    public Transform myTransform;
    public Transform targetTransform;
    // Start is called before the first frame update
    void Start()
    {
        if(myTransform == null)
        {
            myTransform = GetComponent<Transform>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = targetTransform.position - myTransform.position;
        // �� ���� transform ������Ʈ�� �ִ� ���� ������Ʈ�� ��ġ ������ ������ ���
        Quaternion newRotation = Quaternion.LookRotation(direction);
        // �־��� ���� ���͸� �ٶ󺸴� ȸ���� ���, ���� ȸ���� �־��� ���� ���͸� �������� �ϰ� ����� y ��� �����ϵ��� �Ѵ�
        transform.rotation = newRotation;

        //Quaternion aRotation = Quaternion.Euler(new Vector3(30, 0, 0));
        //// Quaternion.Euler �ż��带 ����� ���Ϸ� ������ �ش��ϴ� ȸ���� ��Ÿ����, x�� �������� 30�� ȸ��
        //Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));
        //// x�� �������� 60�� ȸ���� ��Ÿ����.
        //Quaternion.targetRotation = Quaternion.Lerp(aRotation, bRotation, 0.5f);
        ////�� ���� ȸ���� ���̿��� ���� ������ ȸ������ ���, ���� ������ �� ȸ������ �ε巴�� ��Ȳ�Ͽ� �߰� ���� ����ϴ� ���
        //// �� ��° �Ű������� 0.5f�� ���� ������ ����ġ�� ��Ÿ���� 0�� �������� ù ��° �Ű������� ������
        //// 1�� �������� 2��° �Ű������� ������ �� �߰����� ���ο� ȸ������ ������
        //transform.rotation = targetRotation;
    }
}
