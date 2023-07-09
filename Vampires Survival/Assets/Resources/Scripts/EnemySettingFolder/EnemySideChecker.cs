using UnityEngine;

public class EnemySideChecker : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;

    private void Update()
    {
        SideChecker();
    }
    private void SideChecker()
    {
        if (playerPrefab.transform.position.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
