using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealWithHits : MonoBehaviour
{
    int Health = 100;

    internal void IHitYou()
    {
        Health -= 20;
        if (Health < 50)
        {
            // Ensure the object has a Renderer component to change its color
            Renderer rend = GetComponent<Renderer>();
            if (rend != null)
            {
                rend.material.color = Color.red;
            }
        }
        if (Health <= 0)
        {
            // Destroy the GameObject when health reaches or goes below zero
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code here, if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Update code here, if needed
    }
}
