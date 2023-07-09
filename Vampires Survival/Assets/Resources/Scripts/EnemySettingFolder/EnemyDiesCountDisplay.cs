using UnityEngine;
using UnityEngine.UI;

public class EnemyDiesCountDisplay : MonoBehaviour
{
    private int enemyDiesCount;
    [SerializeField] private Text enemyCountText;
    [SerializeField] private Text enemyCountTextForLosePanel;
    private void Update()
    {
        enemyCountText.text = enemyDiesCount.ToString();
        enemyCountTextForLosePanel.text = "EnemyCount: " + enemyDiesCount.ToString();
    }
    public void DiesCount()
    {
        enemyDiesCount++;
    }
   
}
