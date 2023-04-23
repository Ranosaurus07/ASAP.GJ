using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    [SerializeField] private PlayerHealth playerHealth;

    public void Start()
    {
        slider.value = playerHealth.currenthealth;
    }

    public void Update()
    {
        slider.value = playerHealth.currenthealth;
    }


}
