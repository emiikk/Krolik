using System;
using System.Net.Mime;
using TMPro;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private int overallScore = 0;
    private int dogHealth = 3;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameOverText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            overallScore++;
        }
        else if (collision.gameObject.tag == "Slippers")
        {
            if (overallScore > 0)
            {
                overallScore--;
            }

            if (dogHealth <= 3 && dogHealth != 0)
            {
                dogHealth--;
            }
            else if (dogHealth == 0)
            {
                GameOverText.gameObject.SetActive(true);
                GameOverText.text = "Game Over!";
            }
            
        }
        else if (collision.gameObject.tag == "Bone")
        {
            overallScore++;
            if (dogHealth < 3)
            {
                dogHealth++;
            }
        }
    }
}
