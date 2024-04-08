using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayer : MonoBehaviour
{

    public float maxDistance = 1.75f;
    public Vector3 groudSzie= new Vector3(1f, 0.5f, 1f);

    private bool isRotate = false;
    private Rigidbody rb;
    RaycastHit hit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Rotate();

    }

    private void LateUpdate()
    {
        if (rb.isKinematic != Physics.BoxCast(transform.position, groudSzie, Vector3.down, out hit, transform.rotation, maxDistance)) rb.isKinematic = !rb.isKinematic;
    }

    private void Rotate()
    {
        float rr = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;

        if (!isRotate && !OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            if (rr <= -0.95f || Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(new Vector3(0, -15f, 0));
                StartCoroutine(DelayRotate());
            }
            else if (rr >= 0.95f || Input.GetKey(KeyCode.E))
            {
                transform.Rotate(new Vector3(0, 15f, 0));
                StartCoroutine(DelayRotate());
            }
        }
    }


    void OnDrawGizmos()
    {

        // Physics.BoxCast (레이저를 발사할 위치, 사각형의 각 좌표의 절판 크기, 발사 방향, 충돌 결과, 회전 각도, 최대 거리)
        bool isHit = Physics.BoxCast(transform.position, groudSzie, Vector3.down, out hit, transform.rotation, maxDistance);

        Gizmos.color = Color.red;
        if (isHit)
        {
            Gizmos.DrawRay(transform.position, Vector3.down * hit.distance);
            Gizmos.DrawWireCube(transform.position  + Vector3.down * hit.distance, groudSzie);
        }
        else
        {
            Gizmos.DrawRay(transform.position, Vector3.down * maxDistance);
        }
    }
    private IEnumerator DelayRotate()
    {
        isRotate = true;
        yield return new WaitForSeconds(0.5f);
        isRotate = false;
    }
}
