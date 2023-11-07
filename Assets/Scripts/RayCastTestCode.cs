using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTestCode : MonoBehaviour
{
    private int scoreCount = 0;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // 레이케스팅 정보를 얻어올 hit 변수

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // 메인카메라로부터 마우스 위치에 있는 곳에 레이저빔이 나간다(ScreenPointToRay)

            if (Physics.Raycast(ray, out hit))
            {
                // 충돌체에 레이가 충돌이 되었다. 충돌체를 갖고 있는 게임 오브젝트를 찾았다

                GameObject game = hit.transform.gameObject;

                MeshRenderer meshRenderer = game.GetComponent<MeshRenderer>();

                if (meshRenderer != null)
                {
                    Material mat = meshRenderer.material;
                    mat.SetColor("_Color", Color.red);  // _Color

                    Destroy(game, 1f);
                    scoreCount++;
                    Debug.Log(scoreCount);
                }
            }

            else
            {
                // 아무런 충돌체를 찾지 못했다.
                Debug.LogWarning("아무런 충돌체를 찾지 못했다.");
            }
        }


    }
}
