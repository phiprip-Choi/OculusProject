using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    [Header("Welths")]
    public Welth zeusWelth;
    public Welth HeraWelth;
    public Welth athenaWelth;
    public Welth apolloWelth;

    [Header("God's Gift")]
    public GameObject zeusObject;
    public GameObject heraObject;
    public GameObject athenaObject;
    public GameObject apolloObject;

    [Header("Finally Open")]
    public Welth welthOpen;

    public float degree = -60f;

    private bool isFirst = true;
    // Update is called once per frame
    void Update()
    {
        if (!zeusObject.activeSelf && zeusWelth.IsComplete) zeusObject.SetActive(zeusWelth.IsComplete);
        if (!heraObject.activeSelf && HeraWelth.IsComplete) heraObject.SetActive(HeraWelth.IsComplete);
        if (!athenaObject.activeSelf && athenaWelth.IsComplete) athenaObject.SetActive(athenaWelth.IsComplete);
        if (!apolloObject.activeSelf && apolloWelth.IsComplete) apolloObject.SetActive(apolloWelth.IsComplete);


        if (isFirst && welthOpen.IsComplete)
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
