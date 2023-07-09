using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private EnemyDiesCountDisplay enemyDiesCountDisplay;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<WindDamage>() != null)
        {
            enemyDiesCountDisplay.DiesCount();
            gameObject.SetActive(false);
        }
    }
}
