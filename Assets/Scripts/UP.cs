using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP : MonoBehaviour
{
    public float flySpeed = 5f; // �̵� �ӵ�

    void Update()
    {
        // ���� �̵��ϴ� ���͸� ����Ͽ� ���� ��ġ�� ���մϴ�.
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }
}
