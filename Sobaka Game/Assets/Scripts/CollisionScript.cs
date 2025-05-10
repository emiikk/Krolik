using System;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

public class CollisionScript : MonoBehaviour
{
    private int overallScore = 0;
    private int maxScore = 10;
    public int maxHealth = 3;
    public int currentHealth;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameOverText;
    public TextMeshProUGUI GameWinText;
    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        scoreText.text = "Score: " + overallScore;
        if (overallScore == maxScore)
        {
            WinGame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            overallScore++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Slippers")
        {
            if (overallScore > 0)
            {
                overallScore--;
            }

            if (currentHealth <= maxHealth && currentHealth != 0)
            {
                TakeDamage(1);
                if (currentHealth == 0)
                {
                    StopGame();
                }
            }
            Debug.Log(currentHealth);
            Destroy(collision.gameObject);
            
        }
        else if (collision.gameObject.tag == "Bone")
        {
            overallScore++;
            if (currentHealth < maxHealth)
            {
                TakeTreatment(1);
            }
            Destroy(collision.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void TakeTreatment(int treatment)
    {
        currentHealth += treatment;
        healthBar.SetHealth(currentHealth);
    }
    void StopGame()
    {
        GameOverText.text = "Game Over!";
        GameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    
    void WinGame()
    {
        GameWinText.text = "You Win!";
        GameWinText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
