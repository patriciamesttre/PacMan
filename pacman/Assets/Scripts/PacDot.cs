﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacDot : MonoBehaviour
{
    public Diretor diretor;

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.name == "pacman")
        {
            diretor.AdicionarPontos();
            Destroy(gameObject);
        }
            
            
    }


    // Start is called before the first frame update
    void Start()
    {
        diretor = GameObject.FindObjectOfType<Diretor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
