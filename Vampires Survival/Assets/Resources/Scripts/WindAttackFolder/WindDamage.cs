using System.Collections;
using UnityEngine;

public class WindDamage : MonoBehaviour
{
    private float destroyTime = 0.25f;
    private void Update()
    {
        StartCoroutine(DestroyTime());
    }
    private IEnumerator DestroyTime()
    {
        yield return new WaitForSeconds(destroyTime);
        gameObject.SetActive(false);
    }
}
