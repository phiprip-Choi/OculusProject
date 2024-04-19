using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{

    public float degree = -60f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Ŭ��");
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
