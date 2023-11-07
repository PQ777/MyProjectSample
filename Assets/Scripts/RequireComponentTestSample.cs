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
            // 필수, 예외처리 / Get 또는 특정 배열에서 받아오면 예외처리 필수
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
