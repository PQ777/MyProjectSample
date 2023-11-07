using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �� ������Ʈ ������ �Ÿ��� ������ �ǽð����� ��Ÿ���ִ� �����ڵ�
// ���Ϳ� ���� ���� ���ظ� ���� ���� ����
public class ThridSample : MonoBehaviour
{
    public Transform fireObject;
    public Transform secondObject;
    

    private float distance = 0f;
    private Vector3 minusVector;
    private Vector3 normalVector;

    public GUISkin myUISkin;

    private void OnGUI()        // ȭ�鿡 ��ġ�� ���, �����, ���� Ȯ���Ҷ� ��� , ȭ�鿡 ����ϴ� ��(�ؽ�Ʈ ���)
    {
        GUI.skin = myUISkin;
        GUILayout.Label("First Object Position: " + fireObject.position.ToString());
        GUILayout.Label("Second Object position: " + secondObject.position.ToString());
        // ���� ȭ�鿡�� ������Ʈ�� �����϶� ���� ���� ���� ��µǴ� ����:
        // �� ������Ʈ�� ��ġ�� OnGUI�� �����ϰ� �־� �� �����Ӹ��� ȣ��Ǳ� ����
        GUILayout.Label("Distance: " + distance.ToString());
        GUILayout.Label("Minus: " + minusVector.ToString());
        GUILayout.Label("normal: " + normalVector.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(fireObject.position, secondObject.position);    // �� ������Ʈ�� �Ÿ��� ��´�
        minusVector = secondObject.position - fireObject.position;                  // �� ��ġ�� ��(���̳ʽ� ����)
        normalVector = minusVector.normalized;                                      // ���̳ʽ� ���͸� ���� �������Ͱ� ���´�
    }
}
