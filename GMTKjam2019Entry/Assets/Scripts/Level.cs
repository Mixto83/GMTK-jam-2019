﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    #region Variables

    public int ID;
    public Player player;
    public List<Enemy> enemies;

    #endregion

    #region Properties


    #endregion

    #region MonoBehaviour Functions
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player.bullet.isActive)
        {
            checkCollisions();
        }
	}
    #endregion

    #region Methods

    void checkCollisions()
    {
        Collider2D bulletCol = player.bullet.GetComponent<Collider2D>();
        foreach(Enemy enemy in enemies)
        {
            if (!enemy.isDead && bulletCol.bounds.Intersects(enemy.GetComponent<Collider2D>().bounds))
            {
                player.bullet.deactivate();
                enemy.kill();
            }
        }
        
    }

    #endregion
}
