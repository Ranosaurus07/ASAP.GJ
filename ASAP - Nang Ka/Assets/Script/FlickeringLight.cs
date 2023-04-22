using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FlickeringLight : MonoBehaviour
{
    Light2D fLight;
    public float minWaitTime;
    public float maxWaitTime;
    

    public void Awake()
    {
        fLight = GetComponent<Light2D>();
    }

    public void Start()
    {
        StartCoroutine(Flashing());
    }
    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));

            fLight.enabled = !fLight.enabled;
                
        }
    }
}
