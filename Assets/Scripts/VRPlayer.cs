using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPlayer : MonoBehaviour
{

    private bool isRotate = false;
    void Update()
    {
        float rr = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;

        if(!isRotate && !OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            if (rr <= -0.95f)
            {
                transform.Rotate(new Vector3(0, -15f, 0));
                StartCoroutine(DelayRotate());
            }
            else if (rr >= 0.95f)
            {
                transform.Rotate(new Vector3(0, 15f, 0));
                StartCoroutine(DelayRotate());
            }
        }
    }

    private IEnumerator DelayRotate()
    {
        isRotate = true;
        yield return new WaitForSeconds(0.5f);
        isRotate = false;
    }
}
