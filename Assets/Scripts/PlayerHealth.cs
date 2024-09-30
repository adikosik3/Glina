using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI hpText;

    public void TakeDamage(int damage)
    {
        health -= damage;
        hpText.text = "HP: " + health;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(3);
    }
}
