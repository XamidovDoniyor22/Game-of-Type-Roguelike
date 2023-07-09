using System.Collections;
using UnityEngine;

public class ForAttackButton: MonoBehaviour
{
    [SerializeField] private Transform windPosition;
    public bool isAttackAnimation;
    private float animationTime = 0.2f;
    public void WindPrefabActive()
    {
        StartCoroutine(AnimationPeriod());
    }
    private IEnumerator AnimationPeriod()
    {
        isAttackAnimation = true;
        yield return new WaitForSeconds(animationTime);
        isAttackAnimation = false;

        GameObject windPrefab = ObjectPoolForWind.instance.GetPoolObject();

        if (windPrefab != null)
        {
            //StartCoroutine(AnimationPeriod());
            windPrefab.transform.position = windPosition.position;
            windPrefab.SetActive(true);
        }
    }
}
