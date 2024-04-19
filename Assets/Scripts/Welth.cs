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


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            property.Add(other.gameObject);
           // Debug.Log(other.gameObject.name);
            if (Inspect())
            {
                foreach(GameObject go in property) Debug.Log(go.name);
                Debug.Log("Âü");
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer == 8)
        {
            property.Remove(other.gameObject);
            Inspect();
        }
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
