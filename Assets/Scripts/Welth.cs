using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welth : MonoBehaviour
{
    public List<GameObject> welths;
    private HashSet<GameObject> property;

    private void Start()
    {
        welths = new List<GameObject>();
        property = new HashSet<GameObject>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            property.Add(other.gameObject);
            Inspect();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if( other.gameObject.layer == 8)
        {
            property.Remove(other.gameObject);
            Inspect();
        }
    }

    private bool Inspect()
    {
        if(property.Count == welths.Count)
        {
            foreach(GameObject obj in welths)
            {
                if (!property.Contains(obj)) return false;
            }
        }
        return true;
    }
}
