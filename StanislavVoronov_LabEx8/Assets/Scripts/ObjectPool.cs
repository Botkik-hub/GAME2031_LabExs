using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    

    private List<GameObject> _availableObjects = new List<GameObject>();

    public void ReturnObject(GameObject returned)
    {
        returned.SetActive(false);
        _availableObjects.Add(returned);
    }
    
    public GameObject GetObject()
    {
        if (_availableObjects.Count > 0)
        {
            var temp = _availableObjects[0];
            _availableObjects.Remove(temp);
            temp.SetActive(true);
            return temp;
        }
        else
        {
            return Instantiate(prefab);
        }
    }
}
