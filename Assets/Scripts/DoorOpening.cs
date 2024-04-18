using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Å¬¸¯");
            StartCoroutine(RotateDoor());
        }
    }

    IEnumerator RotateDoor()
    {
        while (transform.rotation.eulerAngles.x < 60f)
        {
            transform.rotation = Quaternion.Euler( new Vector3(transform.rotation.eulerAngles.x + 0.5f, 0, 0));
            yield return new WaitForFixedUpdate();
            //transform.Rotate(new Vector3(0.005f * Time.deltaTime, 0, 0));
        } 
    }
}
