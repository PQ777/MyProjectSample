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
        // �����ɽ��� ������ ���� hit ����

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // ����ī�޶�κ��� ���콺 ��ġ�� �ִ� ���� ���������� ������(ScreenPointToRay)

            if (Physics.Raycast(ray, out hit))
            {
                // �浹ü�� ���̰� �浹�� �Ǿ���. �浹ü�� ���� �ִ� ���� ������Ʈ�� ã�Ҵ�

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
                // �ƹ��� �浹ü�� ã�� ���ߴ�.
                Debug.LogWarning("�ƹ��� �浹ü�� ã�� ���ߴ�.");
            }
        }


    }
}
