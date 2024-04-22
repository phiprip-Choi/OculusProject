using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public Welth welth1;
    public Welth welth2;
    public Welth welth3;
    public Welth welth4;

    public float degree = -60f;

    private bool isFirst = true;
    // Update is called once per frame
    void Update()
    {
        bool isOpen = welth1.IsComplete && welth2.IsComplete && welth3.IsComplete && welth4.IsComplete;
        if (isFirst && isOpen)
        {
            Debug.Log("Å¬¸¯");
            isFirst = false;
            StartCoroutine(RotateDoor());
        }
    }

    IEnumerator RotateDoor()
    {
        do
        {
            Debug.Log(transform.localRotation.eulerAngles.z);
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, transform.localEulerAngles.z - 0.5f));
            yield return new WaitForFixedUpdate();
            //transform.Rotate(new Vector3(0.005f * Time.deltaTime, 0, 0));
        } while (transform.localRotation.eulerAngles.z > 360f + degree);
    }
}
