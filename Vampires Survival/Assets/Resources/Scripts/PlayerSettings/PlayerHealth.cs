using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int maxHealth = 100;
    private int currentHealth;
    private int enemyDamage = 20;
    [SerializeField] private GameObject losePanel;

    public bool isHurtAnimationActive = false;

    [SerializeField] private HealthBar healthBar;
    private void Awake()
    {
        Time.timeScale = 1;
    }
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        losePanel.SetActive(false);
    }
    private void Update()
    {
        HealthCheck();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyChasingMechanism>() != null)
        {
            StartCoroutine(HurtAnimationMechanism());
            currentHealth -= enemyDamage;
            healthBar.SetHealth(currentHealth);
        }
    }
    private IEnumerator HurtAnimationMechanism()
    {
        isHurtAnimationActive = true;
        yield return new WaitForSeconds(0.2f);
        isHurtAnimationActive = false;
    }
    private void HealthCheck()
    {
        if(currentHealth <= 0)
        {
            Time.timeScale = 0;
            losePanel.SetActive(true);
        }
    }
}
