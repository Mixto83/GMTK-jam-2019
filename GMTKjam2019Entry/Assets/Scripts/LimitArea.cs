﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitArea : MonoBehaviour {

    public float alpha = 0.1f;
    public float top;
    public float bottom;
    public float right;
    public float left;

	// Use this for initialization
	void Start () {
        var color = gameObject.GetComponent<SpriteRenderer>().material.color;
        color.a = alpha;
        gameObject.GetComponent<SpriteRenderer>().material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
