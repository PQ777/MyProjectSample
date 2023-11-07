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
        // 두 개의 transform 컴포넌트가 있는 게임 오브젝트의 위치 사이의 방향을 계산
        Quaternion newRotation = Quaternion.LookRotation(direction);
        // 주어진 방향 벡터를 바라보는 회전을 계산, 계산된 회전은 주어진 방향 벡터를 정면으로 하고 상단이 y 축과 평행하도록 한다
        transform.rotation = newRotation;

        //Quaternion aRotation = Quaternion.Euler(new Vector3(30, 0, 0));
        //// Quaternion.Euler 매서드를 사용해 오일러 각도에 해당하는 회전을 나타낸다, x축 기준으로 30도 회전
        //Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));
        //// x축 기준으로 60도 회전을 나타낸다.
        //Quaternion.targetRotation = Quaternion.Lerp(aRotation, bRotation, 0.5f);
        ////두 개의 회전값 사이에서 선형 보관된 회전값을 계산, 선형 보간은 두 회전값을 부드럽게 전황하여 중간 값을 계산하는 방법
        //// 세 번째 매개변수인 0.5f는 선형 보관의 가중치를 나타내며 0에 가까울수록 첫 번째 매개변수에 가깝고
        //// 1에 가까울수록 2번째 매개변수에 가깝다 즉 중간값인 새로운 회전값을 가진다
        //transform.rotation = targetRotation;
    }
}
