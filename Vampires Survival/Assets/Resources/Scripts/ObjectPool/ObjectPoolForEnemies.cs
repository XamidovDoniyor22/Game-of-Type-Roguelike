using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolForEnemies : MonoBehaviour
{
    public static ObjectPoolForEnemies instance;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool = 40;
    private float _spawnRadius = 5f;

    [SerializeField] private GameObject enemyPrefab;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(enemyPrefab, Random.insideUnitSphere * _spawnRadius, Quaternion.identity);
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
