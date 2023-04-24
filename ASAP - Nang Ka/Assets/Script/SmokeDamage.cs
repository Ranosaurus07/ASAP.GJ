using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeDamage : MonoBehaviour
{
    [SerializeField] private float damage;
    private PlayerHealth playerbreathe;
    public bool canBreath = true;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerHealth>().takeDamage(damage);
            canBreath = false;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<PlayerHealth>().addBreath(100);
    }

}
