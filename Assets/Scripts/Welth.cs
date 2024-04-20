using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welth : MonoBehaviour
{
    public GameObject[] welths;
    private HashSet<GameObject> property;

    private void Start()
    {
        property = new HashSet<GameObject>();
    }


    public void AddWeldth(GameObject weldth)
    {
        property.Add(weldth);
        //Debug.Log(weldth.name);
        if (Inspect())
        {
            foreach (GameObject go in property)
            {
                Debug.Log(go.name);
                Debug.Log("배치완료");
                go.GetComponent<Grabbable>().enabled = false;
            }
        }
    }

    public void RemoveWeldth(GameObject weldth)
    {
        property.Remove(weldth);
    }

    private bool Inspect()
    {
        if(property.Count == welths.Length)
        {
            foreach(GameObject obj in welths)
            {
                if (!property.Contains(obj)) return false;
            }
            return true;
        }
        return false;
    }
}
