using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 두 오브젝트 사이의 거리와 방향을 실시간으로 나타내주는 예제코드
// 벡터에 대한 개념 이해를 돕기 위한 예제
public class ThridSample : MonoBehaviour
{
    public Transform fireObject;
    public Transform secondObject;
    

    private float distance = 0f;
    private Vector3 minusVector;
    private Vector3 normalVector;

    public GUISkin myUISkin;

    private void OnGUI()        // 화면에 위치를 출력, 디버기, 동적 확인할때 사용 , 화면에 출력하는 라벨(텍스트 출력)
    {
        GUI.skin = myUISkin;
        GUILayout.Label("First Object Position: " + fireObject.position.ToString());
        GUILayout.Label("Second Object position: " + secondObject.position.ToString());
        // 게임 화면에서 오브젝트를 움직일때 값이 변한 값이 출력되는 이유:
        // 각 오브젝트의 위치가 OnGUI를 경유하고 있어 매 프레임마다 호출되기 때문
        GUILayout.Label("Distance: " + distance.ToString());
        GUILayout.Label("Minus: " + minusVector.ToString());
        GUILayout.Label("normal: " + normalVector.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(fireObject.position, secondObject.position);    // 두 오브젝트의 거리를 얻는다
        minusVector = secondObject.position - fireObject.position;                  // 두 위치의 차(마이너스 벡터)
        normalVector = minusVector.normalized;                                      // 마이너스 벡터를 없앤 단위벡터가 나온다
    }
}
