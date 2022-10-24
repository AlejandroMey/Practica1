using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;
    public Text healthtext;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
        healthtext.text = currentHealth.ToString();
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;

        if (currentHealth <= 0)
        {
            Debug.Log("Me han dejado seco");
            transform.position = InitialPosition;
            currentHealth = MaxHealth;
            healthtext.text = currentHealth.ToString();
        }
        else
        {
            Debug.Log("Loco que me petan el anus, mira lo que me queda de vida " + currentHealth);
            healthtext.text = currentHealth.ToString();
        }
    }
}