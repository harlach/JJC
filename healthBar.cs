﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour {

    public Image health;
    public Text healthPercentage;

    private float healthPoints = 100;
    private float totalHealthPoints = 100;

    // Use this for initialization
    void Start()
    {
       //empty for now.
    }

    private void Update()
    {
        healthUpdate();
    }

    void healthUpdate()
    {
        float healthPercent = healthPoints / totalHealthPoints;
        health.rectTransform.localScale = new Vector3(healthPercent, 1, 1);
        healthPercentage.text = (healthPercent * 100).ToString() + '%';

        if(Input.GetKeyDown("p"))
        {
            damagePlayer(10);
            //Debug.Log("The Player took damage");
        }
    } 

    void damagePlayer(float enemyAttack)
    {
        healthPoints = healthPoints - enemyAttack;
    }

    void healPlayer(float healthHealed)
    {

    }

}
    