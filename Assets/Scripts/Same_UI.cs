using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Same_UI : MonoBehaviour
{
    public Transform target1;
    public Transform target2;

    void LateUpdate()
    {
        if (target1 != null && target2 != null)
        {
            target2.position = target1.position;
            target2.rotation = target1.rotation;
        }
        else
        {
            Debug.LogError("Target Transforms are not assigned.");
        }
    }
}
