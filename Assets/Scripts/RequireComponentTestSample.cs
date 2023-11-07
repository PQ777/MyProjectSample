using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]

public class RequireComponentTestSample : MonoBehaviour
{

    private BoxCollider _boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        _boxCollider = GetComponent<BoxCollider>();
        if(_boxCollider == null)
        {
            // �ʼ�, ����ó�� / Get �Ǵ� Ư�� �迭���� �޾ƿ��� ����ó�� �ʼ�
        }
        _boxCollider.isTrigger = true;
        Debug.DrawLine(transform.position, transform.position + Vector3.up * 3, Color.red, 4);

        Debug.LogWarning("Message Warning", gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }
    }
}
