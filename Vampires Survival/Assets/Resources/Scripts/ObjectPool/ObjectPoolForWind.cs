using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolForWind : MonoBehaviour
{
    public static ObjectPoolForWind instance;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 3;

    [SerializeField] private GameObject windPrefab;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(windPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
    public GameObject GetPoolObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
