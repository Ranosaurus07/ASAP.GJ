using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public float startingHealth;
    [SerializeField] private float breathValue;
    public SmokeDamage smoke;
    public float currenthealth { get; private set;}

    public void Awake()
    {
        smoke = GetComponent<SmokeDamage>();
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

    public void addBreath(float _value)
    {
        currenthealth = Mathf.Clamp(currenthealth + _value, 0, startingHealth); 
    }
}
