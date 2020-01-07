using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;
    [SerializeField] int maxHealth, currentHealth;

    private void Awake()
    {
        instance = this;    
    }

    void Start()
    {
        currentHealth = maxHealth;    
    }

    void Update()
    {
        
    }

    public void DealDamage()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
