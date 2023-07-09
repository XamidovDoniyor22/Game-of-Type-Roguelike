using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Transform> windPosition;
    private float delayTimePeriod = 2f;

    private void Start()
    {
        StartCoroutine(EnemySpawnerMechanusm());
    }
    private IEnumerator EnemySpawnerMechanusm()
    {
        while(true)
        {
        var pointIndex = Random.Range(0, windPosition.Count);

        GameObject windPrefab = ObjectPoolForEnemies.instance.GetPoolObject();

        if (windPrefab != null)
        {
            windPrefab.transform.position = windPosition[pointIndex].position;
            windPrefab.SetActive(true);
        }
            yield return new WaitForSeconds(delayTimePeriod);
        }
    }


 
}
