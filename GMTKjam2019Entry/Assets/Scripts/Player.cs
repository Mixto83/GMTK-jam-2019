﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    #region Variables

    public float angle = 0.0f;
    public float speed = 0.05f;
    public float rotSpeed = 1.5f;

    public Bullet bullet;

    #endregion


    #region MonoBehaviour

    void Update()
    {

        //Movement
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horInput, verInput, 0.0f);
        this.transform.position += direction * speed;

        //Rotation
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(new Vector3(0, 0, rotSpeed));
            angle += rotSpeed;
            if (angle >= 360)
            {
                angle -= 360;
            }
        }

        if (Input.GetKey(KeyCode.T))
        {
            this.transform.Rotate(new Vector3(0, 0, -rotSpeed));
            angle -= rotSpeed;
            if (angle < 0)
            {
                angle += 360;
            }
        }

        //Shooting
        if (Input.GetKeyDown(KeyCode.Space) && !bullet.isActive)
        {
            bullet.shoot(transform.position, angle);
        }
    }

    #endregion

}
