using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Welth : MonoBehaviour
{
    [HideInInspector] public bool isGameobject;

    public GameObject[] welths;
    private HashSet<GameObject> property;
    public bool IsComplete { get; private set; }

    [HideInInspector]public GameObject given;

    private void Start()
    {
        IsComplete = false;
        property = new HashSet<GameObject>();
    }


    public void AddWeldth(GameObject weldth)
    {
        property.Add(weldth);
        //Debug.Log(weldth.name);
        if (Inspect())
        {
            IsComplete = true;
            foreach (GameObject go in property)
            {
                Debug.Log(go.name);
                Debug.Log("��ġ�Ϸ�");
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