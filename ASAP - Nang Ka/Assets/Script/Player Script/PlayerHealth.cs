using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public float startingHealth;
    public float currenthealth { get; private set;}

    public void Awake()
    {
        currenthealth = startingHealth;
    }

    public void takeDamage(float _damage)
    {
        currenthealth = Mathf.Clamp(currenthealth - _damage, 0, startingHealth);
        
        if (currenthealth > 0)
        {
            //player hurt
        }
        else
        {
            //player dead
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            takeDamage(5);
        }
    }
}
