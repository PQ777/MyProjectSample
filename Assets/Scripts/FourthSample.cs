using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthSample : MonoBehaviour
{
    private Transform myTransform = null;
    public Vector3 offsetVector3 = Vector3.zero;    // 제로이면 0, 0, 0 이다
    public float Speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        // 캐싱
        //transform 안씀, 할때마다 매번 접근 하기 때문, 계속 컴포넌터를 불러오기 때문
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
        // 게임용 오브젝트 이동
        myTransform.Translate(offsetVector3 * Speed * Time.deltaTime);
    }
}
