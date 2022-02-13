using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public healthBar healthBar;
    public gameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        if (collision.gameObject.tag == "bullets")
        {
           Debug.Log("bullet");
           TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
      currentHealth -= damage;

      healthBar.setHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
      if (currentHealth < 1) {
        gameManager.gameOver();
      }
    }
}
