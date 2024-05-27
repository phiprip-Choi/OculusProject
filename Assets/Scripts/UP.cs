using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UP : MonoBehaviour
{
    public float flySpeed = 5f; // 이동 속도

    void Update()
    {
        // 위로 이동하는 벡터를 계산하여 현재 위치에 더합니다.
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }
}
